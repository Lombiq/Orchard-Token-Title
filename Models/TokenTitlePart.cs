using System.ComponentModel.DataAnnotations;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Aspects;
using Orchard.ContentManagement.Utilities;

namespace Piedone.TokenTitle.Models
{
    public class TokenTitlePart : ContentPart<TokenTitlePartRecord>, ITitleAspect
    {
        [Required, StringLength(1024)]
        public string TitlePattern
        {
            get { return Retrieve(x => x.TitlePattern); }
            set { Store(x => x.TitlePattern, value); }
        }

        private readonly LazyField<string> _title = new LazyField<string>();
        internal LazyField<string> TitleField { get { return _title; } }
        public string Title
        {
            get { return _title.Value; }
        }
    }
}
