open System
open System.IO
open ArthurHNL.StartupScript.Lib.ClearFolders

[<EntryPoint>]
let main argv =
    clearFolder "C:\\Copyfolder" true
    0