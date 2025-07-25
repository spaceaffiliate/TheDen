// SPDX-FileCopyrightText: 2023 Chief-Engineer <119664036+Chief-Engineer@users.noreply.github.com>
// SPDX-FileCopyrightText: 2023 Debug <49997488+DebugOk@users.noreply.github.com>
// SPDX-FileCopyrightText: 2023 Leon Friedrich <60421075+ElectroJr@users.noreply.github.com>
// SPDX-FileCopyrightText: 2023 Riggle <27156122+RigglePrime@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 sleepyyapril <123355664+sleepyyapril@users.noreply.github.com>
//
// SPDX-License-Identifier: MIT

using Content.Shared.Administration;
using Robust.Shared.Console;
using Content.Server.EUI;

namespace Content.Server.Administration.Commands;

[AdminCommand(AdminFlags.Ban)]
public sealed class BanPanelCommand : LocalizedCommands
{

    [Dependency] private readonly IPlayerLocator _locator = default!;
    [Dependency] private readonly EuiManager _euis = default!;

    public override string Command => "banpanel";

    public override async void Execute(IConsoleShell shell, string argStr, string[] args)
    {
        if (shell.Player is not { } player)
        {
            shell.WriteError(Loc.GetString("cmd-banpanel-server"));
            return;
        }

        switch (args.Length)
        {
            case 0:
                _euis.OpenEui(new BanPanelEui(), player);
                break;
            case 1:
                var located = await _locator.LookupIdByNameOrIdAsync(args[0]);
                if (located is null)
                {
                    shell.WriteError(Loc.GetString("cmd-banpanel-player-err"));
                    return;
                }
                var ui = new BanPanelEui();
                _euis.OpenEui(ui, player);
                ui.ChangePlayer(located.UserId, located.Username, located.LastAddress, located.LastHWId);
                break;
            default:
                shell.WriteLine(Loc.GetString("cmd-ban-invalid-arguments"));
                shell.WriteLine(Help);
                return;
        }
    }
}
