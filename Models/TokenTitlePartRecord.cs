using Orchard.ContentManagement.Records;
using System.ComponentModel.DataAnnotations;

namespace Piedone.TokenTitle.Models
{
    public class TokenTitlePartRecord : ContentPartRecord
    {
        [StringLength(1024)]
        public virtual string TitlePattern { get; set; }
    }
}
