#r "tools/FAKE/tools/FakeLib.dll"

open Fake

let buildDir = "./build"
let testDir  = "./test/"


Target "Deps" (fun _ ->
    RestorePackages()
)

Target "Clean" (fun _ -> 
    ignore(Shell.Exec("git", "clean -x -d -f"))
)

Target "Compile" (fun _ ->
    !! "src/**/*.csproj"
    |> MSBuildRelease buildDir "Build"
    |> Log "AppBuild-Output: "
)

Target "CompileTests" (fun _ ->
    !! "src/**/*.Test.csproj"
    |> MSBuildRelease testDir "Build"
    |> Log "AppBuild-Output: "
)

Target "GetTestRunner" (fun _ ->
    ignore(Shell.Exec(@".\tools\Nuget.exe", "install Nunit.Runners -Version \"2.6.4\" -ExcludeVersion -OutputDirectory \"" + testDir + "\""))
)

Target "Test" (fun _ ->
    !! ("test/*.Test.dll")
    |> NUnit (fun p ->
       {p with
           DisableShadowCopy = true;
           OutputFile = testDir + "TestResults.xml"
       })
)

// Build order
"Deps"
  ==> "Compile"
  ==> "Test"

"GetTestrunner"
  ==> "CompileTests"
  ==> "Test"

RunTargetOrDefault "Test"
