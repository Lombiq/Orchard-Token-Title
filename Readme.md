# Token Title Orchard module Readme



## Project Description

Adds token configuration capability to the TitlePart in Orchard.


## Features

- New part: TokenTitlePart
- The content item's title can be defined with a token pattern (so e.g. the title can change according to the request)
- Import/export support


## Documentation

### Usage

After installing and enabling there will be a new attachable content part, TokenTitlePart. Attach this part to a type instead of the regular TitlePart to have tokenized title for that type.
Since TokenTitlePart is an ITitleAspect implementation it behaves pretty much like TitlePart (but it can't be searched).

### Notes on Autoroute

If the content type has AutoroutePart attached there is no possibility to auto-generate the url of the item from the title, since tokens are replaced per request. So either shouldn't use the DisplayText token for slug generation or you should set the slug manually.


You can install the module from the [Gallery](http://gallery.orchardproject.net/List/Modules/Orchard.Module.Piedone.TokenTitle).

The module's source is available in two public source repositories, automatically mirrored in both directions with [Git-hg Mirror](https://githgmirror.com):

- [https://bitbucket.org/Lombiq/orchard-token-title](https://bitbucket.org/Lombiq/orchard-token-title) (Mercurial repository)
- [https://github.com/Lombiq/Orchard-Token-Title](https://github.com/Lombiq/Orchard-Token-Title) (Git repository)

Bug reports, feature requests and comments are warmly welcome, **please do so via GitHub**.
Feel free to send pull requests too, no matter which source repository you choose for this purpose.

This project is developed by [Lombiq Technologies Ltd](http://lombiq.com/). Commercial-grade support is available through Lombiq.