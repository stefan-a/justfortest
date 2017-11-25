echo "Setup for SonarQube"
d:\SonarQube\runners\MSBuild.SonarQube.Runner.exe begin /k:"san.sonarqube.evaluation" /n:"Lone Wolf" /v:"0.1" /d:sonar.cs.vstest.reportsPaths="%CD%\TestResults\*.trx"
msbuild /t:rebuild
dotnet test --no-build --logger "trx;LogFileName=test-output.trx"
d:\SonarQube\runners\MSBuild.SonarQube.Runner.exe end
