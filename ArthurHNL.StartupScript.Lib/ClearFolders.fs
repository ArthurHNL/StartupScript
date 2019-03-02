namespace ArthurHNL.StartupScript.Lib

open System.IO

module ClearFolders =

    let rec clearFolder path clearSubdirs =
        if not <| Directory.Exists(path) then raise (DirectoryNotFoundException(path))

        for file in Directory.EnumerateFiles(path) do
            File.Delete(Path.Combine(path, file))

        if clearSubdirs then
            for subdir in Directory.EnumerateDirectories(path) do
                let fullPath = Path.Combine(path, subdir)
                clearFolder fullPath clearSubdirs
                Directory.Delete(fullPath)
