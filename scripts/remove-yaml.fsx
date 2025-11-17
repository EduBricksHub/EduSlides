open System
open System.IO
open System.Text.RegularExpressions

/// Regex to match YAML blocks of the form
/// ---\n ... \n---
/// Handles CRLF or LF line endings.
let yamlBlockRegex =
    Regex(@"(?ms)^---\s*\r?\n.*?\r?\n---\s*$")

/// Removes all YAML blocks anywhere in the text
let removeYamlBlocks (text: string) =
    yamlBlockRegex.Replace(text, "").TrimStart()

/// Collect markdown files by pattern
let getMarkdownFiles (root: string) (pattern: string) (recursive: bool) =
    Directory.GetFiles(
        root,
        pattern,
        if recursive then SearchOption.AllDirectories else SearchOption.TopDirectoryOnly
    )

/// Process one file: remove YAML and overwrite
let cleanFile (path: string) =
    let original = File.ReadAllText(path)
    let cleaned = removeYamlBlocks original
    File.WriteAllText(path, cleaned)
    printfn "Cleaned YAML: %s" path


let sourceDir = __SOURCE_DIRECTORY__

let folder = Path.Combine(sourceDir, "arc-overview")
let pattern = "*.md"                    // "*.markdown" also possible
let recursive = true                    // or false

let files = getMarkdownFiles folder pattern recursive

if files.Length = 0 then
    printfn "No markdown files found in: %s" folder
else
    printfn "Cleaning %d markdown file(s)..." files.Length
    files |> Array.iter cleanFile
    printfn "Done."
