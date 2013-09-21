using Orchard.ContentManagement.MetaData;
using Orchard.Core.Contents.Extensions;
using Orchard.Data.Migration;
using Piedone.TokenTitle.Models;

namespace Piedone.TokenTitle
{
    public class Migrations : DataMigrationImpl
    {
        public int Create()
        {
            SchemaBuilder.CreateTable(typeof(TokenTitlePartRecord).Name,
                table => table
                    .ContentPartRecord()
                    .Column<string>("TitlePattern", column => column.WithLength(1024))
                );

            ContentDefinitionManager.AlterPartDefinition("TokenTitlePart",
                part => part
                    .Attachable()
                    .WithDescription("Behaves similarly to Title Part but the title can contain tokens that will be evaluated when the item is displayed.")
                );


            return 1;
        }

        public int UpdateFrom1()
        {
            ContentDefinitionManager.AlterPartDefinition("TokenTitlePart",
                part => part
                    .WithDescription("Behaves similarly to Title Part but the title can contain tokens that will be evaluated when the item is displayed.")
                );


            return 2;
        }
    }
}
