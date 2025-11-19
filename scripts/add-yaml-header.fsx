open System
open System.IO
open System.Text.RegularExpressions

/// Given a YAML string, wrap it in --- ... --- markers
let wrapYaml (yaml: string) =
    $"---\n{yaml}\n---\n\n"

/// Build a YAML header from a list of key-value strings
let yamlFromArray (pairs: (string * string) list) =
    pairs |> List.map (fun (k,v) -> $"{k}: {v}") |> String.concat "\n"
        

/// Merge an optional YAML header into a markdown body

let mergeYamlHeader (defaultYaml: string option) (body: string) =
    let header =
        match defaultYaml with
        | Some d -> wrapYaml d
        | None -> ["author", " "; "layout", ""; "date", ""] |> yamlFromArray |> wrapYaml
    header + body

/// Collect markdown files by pattern
let getMarkdownFiles (root: string) (pattern: string) (recursive: bool) =
    Directory.GetFiles(
        root,
        pattern,
        if recursive then SearchOption.AllDirectories else SearchOption.TopDirectoryOnly
    )

/// Process one file: remove YAML and overwrite
let addYamlToFile (path: string) (yamlHeader: string) =
    let original = File.ReadAllText(path)
    let added = mergeYamlHeader (Some yamlHeader) original
    File.WriteAllText(path, added)
    printfn "Added YAML to: %s" path

////////////////// 

let sourceDir = __SOURCE_DIRECTORY__

let defaultYaml =
    ["author", ""; "layout", "default"; "date", ""]
    |> yamlFromArray

let folder = Path.Combine(sourceDir, "arc-overview")
let pattern = "*.md"                    // "*.markdown" also possible
let recursive = true                    // or false

let files = getMarkdownFiles folder pattern recursive

if files.Length = 0 then
    printfn "No markdown files found in: %s" folder
else
    files |> Array.iter (fun f -> addYamlToFile f defaultYaml)
    printfn "Done."
