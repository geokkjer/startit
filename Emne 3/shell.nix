# shell.nix
with import <nixpkgs> {};

mkShell {
  name = "dotnet-env";
  packages = [
    (with dotnetCorePackages; combinePackages [
      sdk_6_0
      sdk_7_0
      sdk_8_0
      sdk_9_0
    ])
    csharp-ls
  ];
}
