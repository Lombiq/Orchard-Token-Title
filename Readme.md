# Token Title Orchard module



## About

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


## Contributing and support

Bug reports, feature requests, comments, questions, code contributions, and love letters are warmly welcome, please do so via GitHub issues and pull requests. Please adhere to our [open-source guidelines](https://lombiq.com/open-source-guidelines) while doing so.

This project is developed by [Lombiq Technologies](https://lombiq.com/). Commercial-grade support is available through Lombiq.