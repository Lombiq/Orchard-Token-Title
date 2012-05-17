using Orchard.ContentManagement;
using Orchard.ContentManagement.Drivers;
using Orchard.ContentManagement.Handlers;
using Piedone.TokenTitle.Models;

namespace Piedone.TokenTitle.Drivers
{
    public class TokenTitlePartDriver : ContentPartDriver<TokenTitlePart>
    {
        protected override string Prefix
        {
            get { return "Piedone.TokenTitle.TokenTitlePart"; }
        }

        protected override DriverResult Display(TokenTitlePart part, string displayType, dynamic shapeHelper)
        {
            return Combined(
                ContentShape("Parts_Title",
                    () => shapeHelper.Parts_Title(Title: part.Title)),
                ContentShape("Parts_Title_Summary",
                    () => shapeHelper.Parts_Title_Summary(Title: part.Title)),
                ContentShape("Parts_Title_SummaryAdmin",
                    () => shapeHelper.Parts_Title_SummaryAdmin(Title: part.Title))
                );
        }

        protected override DriverResult Editor(TokenTitlePart part, dynamic shapeHelper)
        {
            return ContentShape("Parts_TokenTitle_Edit",
                () =>   shapeHelper.EditorTemplate(
                        TemplateName: "Parts.TokenTitlePart",
                        Model: part,
                        Prefix: Prefix));
        }

        protected override DriverResult Editor(TokenTitlePart part, IUpdateModel updater, dynamic shapeHelper)
        {
            updater.TryUpdateModel(part, Prefix, null, null);

            return Editor(part, shapeHelper);
        }

        protected override void Importing(TokenTitlePart part, ImportContentContext context)
        {
            part.TitlePattern = context.Attribute(part.PartDefinition.Name, "TitlePattern");
        }

        protected override void Exporting(TokenTitlePart part, ExportContentContext context)
        {
            context.Element(part.PartDefinition.Name).SetAttributeValue("TitlePattern", part.TitlePattern);
        }
    }
}
