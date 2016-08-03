nuget restore
md artifacts
"C:\Program Files (x86)\MSBuild\14.0\bin\MSBuild.exe" SJKP.LiveSettings.SiteExtensions\SJKP.LiveSettings.SiteExtensions.csproj /t:pipelinePreDeployCopyAllFilesToOneFolder /p:_PackageTempDir="..\artifacts";AutoParameterizationWebConfigConnectionStrings=false;Configuration=Release;SolutionDir="."
xcopy SJKP.LiveSettings.SiteExtensions\bin\Release\*.* artifacts\bin /sy