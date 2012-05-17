using System.ComponentModel.DataAnnotations;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Aspects;
using Orchard.Core.Common.Utilities;

namespace Piedone.TokenTitle.Models
{
    public class TokenTitlePart : ContentPart<TokenTitlePartRecord>, ITitleAspect
    {
        [Required, StringLength(1024)]
        public string TitlePattern
        {
            get { return Record.TitlePattern; }
            set { Record.TitlePattern = value; }
        }

        private readonly LazyField<string> _title = new LazyField<string>();
        public LazyField<string> TitleField { get { return _title; } }
        public string Title
        {
            get { return _title.Value; }
        }
    }
}
