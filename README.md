# SmogonTeamParser

Take non-helpful pokemon set export from smogon team builder and parse into json format that [smogon/damage-calc](https://github.com/smogon/damage-calc) can use.

## How To Use

Create a .txt file on desktop (example: smogonset.txt).

Put the Smogon set export for ONE pokemon in the .txt file.

```sh
Hippopotas(Roxanne) (Hippopotas) @ Sitrus Berry
Ability: Sand Stream
Level: 16
IVs: 20 HP / 20 Def / 20 SpA / 20 SpD / 20 Spe
- Yawn
- Bulldoze
- Substitute
- Slack Off
```

Get the FULL directory of the .txt file you created:

```sh
C:\\Users\\{USERNAME}\\Desktop\\smogonset.txt)
```

- Build from root repo directory:

```sh
dotnet build
```

Navigate to bin directory containing exe file

```sh
cd SmogonTeamParser\bin\Debug\net7.0
```

Run executeable with the .txt filepath as the ONLY argument.

```sh
.\SmogonTeamParser.exe C:\\Users\\{USERNAME}\\Desktop\\smogonset.txt
```

Copy the JSON Output:

```sh
{"level":16,"ability":"Sand Stream","item":"Sitrus Berry","nature":"Serious","ivs":{"hp":20,"at":31,"df":20,"sa":31,"sd":31,"sp":20},"evs":null,"moves":["Yawn","Bulldoze","Substitute","Slack Off"]}
```