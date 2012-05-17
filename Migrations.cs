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

            ContentDefinitionManager.AlterPartDefinition("TokenTitlePart", builder => builder.Attachable());


            return 1;
        }
    }
}
