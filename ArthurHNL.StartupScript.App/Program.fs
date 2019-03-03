open ArthurHNL.StartupScript.Lib.ClearFolders
open ArthurHNL.StartupScript.Lib.LaunchPrograms

[<EntryPoint>]
let main argv =
    clearFolder "C:\\Copyfolder" true
    let pageant : LaunchInfo = { 
        executablePath = "C:\\Program Files\\PuTTY\\pageant.exe";
        arguments = "C:\\Users\\arthu\.ssh\id_rsa.ppk";
        workingDirectory = "C:\\"; }
    let executables = [pageant]
    launchPrograms executables
    0
