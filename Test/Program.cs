using DockerScript;
using DockerScript.StageSteps;

var dockerfile = new DockerFile();

dockerfile.AddStage("base", "mcr.microsoft.com/dotnet/aspnet:6.0", (i) => {
    i.WorkingDir("/app");
    i.Expose(80);
    i.Run(sb => {
        sb.AppendLine("echo \"hello\"");
        sb.AppendLine("echo \"world\"");
    });
});

dockerfile.AddStage("build", "mcr.microsoft.com/dotnet/sdk:6.0", (i) => {
    i.WorkingDir("/src");
    i.Copy(".");
    i.WorkingDir("/src/app");
    i.Run("dotnet restore \"app.csproj\"");
    i.Run("dotnet build \"app.csproj\"  -c Release -o /app/build");
});

dockerfile.AddStage("publish", "build", (i) => {
    i.Run("dotnet publish \"app.csproj\"  -c Release -o /app/publish");
});

dockerfile.AddStage("final", "base", (i) => {
    i.OnBuild("echo \"on build\"");
    i.WorkingDir("/app");
    i.CopyFrom("publish", "/app/publish", ".");
    i.Entrypoint("dotnet", "app.dll");
    i.HttpHealthCheck("http://localhost");
});

Console.Write(dockerfile.Build(new BuildContext() {
}));