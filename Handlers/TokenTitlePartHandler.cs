using System;
using System.Collections.Generic;
using Orchard.ContentManagement.Handlers;
using Orchard.Tokens;
using Piedone.TokenTitle.Models;
using Orchard.Data;
using Orchard.ContentManagement;
using Orchard.Environment;

namespace Piedone.TokenTitle.Handlers
{
    public class TokenTitlePartHandler : ContentHandler
    {
        public TokenTitlePartHandler(IRepository<TokenTitlePartRecord> repository, Work<ITokenizer> tokenizerWork)
        {
            Filters.Add(StorageFilter.For(repository));

            OnActivated<TokenTitlePart>((context, part) =>
            {
                part.TitleField.Loader(() =>
                    {
                        return tokenizerWork.Value.Replace(
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
