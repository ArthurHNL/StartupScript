namespace ArthurHNL.StartupScript.Lib

open System.IO

module ClearFolders =

    let rec clearFolder path clearSubdirs =
        if not <| Directory.Exists(path) then raise (DirectoryNotFoundException(path))

        Seq.iter 
            (fun filePath -> File.Delete(filePath))
            (Seq.map
                (fun file -> Path.Combine(path, file))
                (Directory.EnumerateFiles(path)))

        match clearSubdirs with 
        | true ->
            Seq.iter
                (fun subdir -> 
                    clearFolder subdir clearSubdirs
                    Directory.Delete(subdir))
                (Seq.map
                    (fun subdir -> Path.Combine(path, subdir))
                    (Directory.EnumerateDirectories(path)))
        | _ -> ()
