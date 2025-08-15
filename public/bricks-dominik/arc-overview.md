---
date: 2023-11-14
title: ARC
author:
- name: Dominik Brilhaus
  github: https://github.com/brilator
  orcid: https://orcid.org/0000-0001-9021-3197
layout: default
---

# Annotated Research Context (ARC)

<img src="/kb/src/assets/images/start-here/arc-bag.svg" />

Your entire investigation in a single unified bag

---
layout: default
---

## The ARC scaffold structure

<img src="/kb/src/assets/images/start-here/arc-scaffold.svg" />

---
layout: two-columns
src: './arc-standards.md'
---

---
layout: default
---

## ISA abstract model in a nutshell

<img src="/kb/src/assets/images/start-here/standards-isa-in-a-nutshell.svg" />

---
layout: default
---

## ISA and CWL – Connected by similarity

<img src="/kb/src/assets/images/start-here/standards-isa-cwl.svg" />

---
layout: default
---

## Metadata annotation – from sample to data

<img src="/kb/src/assets/images/start-here/arc-prototypic.svg" />

---
layout: default
---

## Modular separation of experimental processes

<img src="/kb/src/assets/images/start-here/arc-prototypic-assay-identify.svg" />

---
layout: default
---

## Modular separation of experimental processes

<img src="/kb/src/assets/images/start-here/arc-prototypic-assay-modular2.svg" />

---
layout: default
---

## Applying standard procedures to sample record

<img src="/kb/src/assets/images/start-here/arc-prototypic-assay-sop.svg" />

---
layout: default
---

## Realization of lab-specific metadata with templates

<img src="/images-tm/swate-metadatatemplates.png"/>

Facilities can define their most common workflows as templates

---
layout: default
---

## Data analysis: CWL workflows and runs

<img src="/kb/src/assets/images/start-here/arc-prototypic-workflows-cwl1.svg" />

---
layout: default
---

## Metadata annotation – from data to result

<img src="/kb/src/assets/images/start-here/arc-prototypic-workflows-cwl2.svg" />

---
layout: default
---

## Everything is a file

The ARC is a **data-centric** approach to RDM

<img src="/images-tm/arc-data-centric-everything-is-a-file.drawio.svg" />

---
layout: default
---

## No technical lock-in

<img src="/images-tm/arc-tool-assistance.drawio.svg" style="width:900px;display: block; margin: auto;margin-top:150px"/>

(Meta)data transparency with tool assistance but **no technical lock-in**

---
layout: default
---

## Two representations of the ARC

<img src="/images-tm/ro-crate-vs-scaffold.png" style="width:900px;display: block; margin: auto;margin-top:100px" />

---
layout: two-columns
---

## Two sides of the same coin

::left::

**"Developer View": RO-Crate**


```yaml{*}{maxHeight:'140px'}
{
"Identifier": "Proteomics_MS",
"MeasurementType": {
  "annotationValue": "Proteomics_MS",
  "termSource": "MS",
  "termAccession": "https://purl.obolibrary.org/obo/FMS_1003348"
},
"TechnologyType": {
  "annotationValue": "Mass Spectrometry",
  "termSource": "NCIT",
  "termAccession": "https://bioregistry.io/NCIT:C17156"
},
"TechnologyPlatform": {
  "annotationValue": "timsTOF Pro 2",
  "termSource": "MS",
  "termAccession": "MS:1003230"
},
...
```

<span height=50px></span>

```yaml{*}{maxHeight:'200px'}
...
"Tables": [
  {
    "name": "ProtDigest",
    "header": [
      {
        "headertype": "Parameter",
        "values": [
          {
            "annotationValue": "sample mass",
            "termSource": "MS",
            "termAccession": "MS:1000004"
          }
        ]
      },
      {
        "headertype": "Parameter",
        "values": [
          {
            "annotationValue": "Protein Precipitation",
            "termSource": "NCIT",
            "termAccession": "NCIT:C113065"
          }
        ]
      },
...
```

::right::

  **"User View": ARC Scaffold and metadata tables**

  <img src="/images-tm/two-sides-01-user.png" style="padding-bottom:20px"/>
  <img src="/images-tm/two-sides-02-user.png" />
