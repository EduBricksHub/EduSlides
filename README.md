# [WIP] Slide decks

Minimal repo based on [Slidev](http://sli.dev/) to create EduBricks-based slide decks for FAIR asset reuse.

Idea:
  - this repo only handles slides and styles (no assets, no images)
  - images are important from elsewhere


### Slidev

[Slidev](http://sli.dev/) is a pretty strong vue.js based framework to build slides from markdown files.

- This can also be used to compile slide decks from smaller slide decks ("bricks")
- There's a [vscode extension](https://sli.dev/features/vscode-extension) available
- during watch or build it checks, that all referenced / reused images or imported bricks actually exist

#### Install slidev

```bash
## npm init slidev (done once for the repo)
npm install ## (done once per machine)
```

#### Watch a slidev slide deck

You can see an example slide deck built with slidev here using the following command. 
This should open a browser with the presentation, including some presentation controls in the bottom-left corner.
(Note: this will only work, if above `git submodule` (i.e. the images from knowledge base) are correctly added.)

```bash
npm run dev -- slide-decks/2025-09-09_ceplas-arcify/slides.md
```

#### Export a slidev slide deck to pdf

You can directly export a slide deck to pdf using slidev's browser controls or use the export command, e.g.

```bash
npm run export -- slide-decks/2025-09-09_ceplas-arcify/slides.md --output slide-decks/2025-09-09_ceplas-arcify/slides.pdf
```
