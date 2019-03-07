namespace ArthurHNL.StartupScript.Lib

open System.Diagnostics

module LaunchPrograms =
    type LaunchInfo = { executablePath : string; arguments : string; workingDirectory : string }

    let private launchProgram programInfo =
        let launchInfo = ProcessStartInfo(FileName = programInfo.executablePath, Arguments = programInfo.arguments, WorkingDirectory = programInfo.workingDirectory)
        Process.Start(launchInfo) |> ignore

    let rec launchPrograms programsToLaunch =
        match programsToLaunch with
        | head :: tail ->
            launchProgram head
            launchPrograms tail
        | [] -> ()
