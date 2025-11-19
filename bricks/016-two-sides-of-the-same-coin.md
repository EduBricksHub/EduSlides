---
author: 
layout: two-columns
date: 
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

  <img src="https://raw.githubusercontent.com/EduBricksHub/images/a81d3e5f58edd27a559057f496b6ce043afb984e/arc-design/two-sides-01-user.png" style="padding-bottom:20px"/>
  <img src="https://raw.githubusercontent.com/EduBricksHub/images/a81d3e5f58edd27a559057f496b6ce043afb984e/arc-design/two-sides-02-user.png" />