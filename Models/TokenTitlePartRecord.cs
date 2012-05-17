using Orchard.ContentManagement.Records;

namespace Piedone.TokenTitle.Models
{
    public class TokenTitlePartRecord : ContentPartRecord
    {
        public virtual string TitlePattern { get; set; }
    }
}
