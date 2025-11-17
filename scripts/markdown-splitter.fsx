open System
open System.IO
open System.Text.RegularExpressions

/// Converts a heading line to a slug (for filenames)
let slugify (text: string) =
    text.ToLowerInvariant()
        .Replace("#", "")
        .Trim()
        .Replace(" ", "-")
        .Replace(":", "")
        .Replace(".", "")
        .Replace(",", "")


/// Splits a markdown file into slides
let splitMarkdown (content: string) (pattern: string) =
    // Split on `---` or heading (lines starting with #)
    Regex.Split(content, pattern, RegexOptions.Multiline)
    |> Array.map (fun s -> s.Trim())
    |> Array.filter (fun s -> not (String.IsNullOrWhiteSpace s))

/// Writes each slide to a file
let writeSlides (slides: string[]) (outputDir: string) =
    Directory.CreateDirectory(outputDir) |> ignore

    slides
    |> Array.iteri (fun i slide ->
        let title =
            Regex.Match(slide, @"^#+\s*(.+)", RegexOptions.Multiline)
            |> fun m -> if m.Success then slugify m.Groups.[1].Value else $"slide-{i+1}"

        let fileName =
            let index = sprintf "%03d" (i + 1)
            Path.Combine(outputDir, $"{index}-{title}.md")

        File.WriteAllText(fileName, slide)
        printfn "Wrote %s" fileName
    )

// [<EntryPoint>]

let sourceDir = __SOURCE_DIRECTORY__

let argv = [
            Path.Combine(sourceDir, "../public/bricks-dominik/arc-overview.md")
            Path.Combine(sourceDir, "test")
            // @"(?=^---$|^# |^## )"
            @"(?=^# |^## )"
            ]


// let main argv =
if argv.Length < 2 
then
    printfn "Usage: md-splitter <input.md> <output-dir>"
    1
else
    let inputFile = argv.[0]
    let outputDir = argv.[1]
    let splitPattern = argv.[2]
    let content = File.ReadAllText(inputFile)
    let slides = splitMarkdown content splitPattern
    writeSlides slides outputDir
    0
