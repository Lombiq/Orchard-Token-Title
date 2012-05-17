using System;
using System.Collections.Generic;
using Orchard.ContentManagement.Handlers;
using Orchard.Tokens;
using Piedone.TokenTitle.Models;
using Orchard.Data;
using Orchard.ContentManagement;

namespace Piedone.TokenTitle.Handlers
{
    public class TokenTitlePartHandler : ContentHandler
    {
        public TokenTitlePartHandler(IRepository<TokenTitlePartRecord> repository, Lazy<ITokenizer> tokenizer)
        {
            Filters.Add(StorageFilter.For(repository));

            OnLoaded<TokenTitlePart>((context, part) =>
            {
                part.TitleField.Loader(() =>
                    {
                        return tokenizer.Value.Replace(
                            part.TitlePattern,
                            new Dictionary<string, object> { { "Content", context.ContentItem } });
                    });
            });
        }

        protected override void GetItemMetadata(GetContentItemMetadataContext context)
        {
            var part = context.ContentItem.As<TokenTitlePart>();

            if (part != null)
            {
                context.Metadata.DisplayText = part.Title;
            }
        }
    }
}
