# SPDX-FileCopyrightText: 2023 DrSmugleaf <DrSmugleaf@users.noreply.github.com>
# SPDX-FileCopyrightText: 2023 Vasilis <vasilis@pikachu.systems>
# SPDX-FileCopyrightText: 2023 coolmankid12345 <55817627+coolmankid12345@users.noreply.github.com>
# SPDX-FileCopyrightText: 2023 coolmankid12345 <coolmankid12345@users.noreply.github.com>
# SPDX-FileCopyrightText: 2023 deltanedas <@deltanedas:kde.org>
# SPDX-FileCopyrightText: 2024 DEATHB4DEFEAT <77995199+DEATHB4DEFEAT@users.noreply.github.com>
# SPDX-FileCopyrightText: 2024 Mr. 27 <45323883+Dutch-VanDerLinde@users.noreply.github.com>
# SPDX-FileCopyrightText: 2024 deltanedas <39013340+deltanedas@users.noreply.github.com>
# SPDX-FileCopyrightText: 2025 Timfa <timfalken@hotmail.com>
# SPDX-FileCopyrightText: 2025 sleepyyapril <123355664+sleepyyapril@users.noreply.github.com>
#
# SPDX-License-Identifier: AGPL-3.0-or-later AND MIT

## Rev Head

roles-antag-rev-head-name = Head Revolutionary
roles-antag-rev-head-objective = Your objective is to take over the station by converting people to your cause and killing all Command staff on station.

head-rev-role-greeting =
    You are a Head Revolutionary.
    You are tasked with removing all of Command from station via death, exilement or imprisonment.
    The Syndicate has sponsored you with a manifesto that persuades the crew to your side.
    Beware, this won't work on Security or Command - their loyalty is unwavering.
    Viva la revolución!

head-rev-briefing =
    Use the manifesto to convert people to your cause.
    Get rid of all heads to take over the station.

head-rev-break-mindshield = The Mindshield was destroyed!

## Rev

roles-antag-rev-name = Revolutionary
roles-antag-rev-objective = Your objective is to ensure the safety and follow the orders of the Head Revolutionaries as well as getting rid of all Command staff on station.

rev-break-control = {$name} has remembered their true allegiance!

rev-role-greeting =
    You are a Revolutionary.
    You are tasked with taking over the station and protecting the Head Revolutionaries.
    Get rid of all of the Command staff.
    Viva la revolución!

rev-briefing = Help your head revolutionaries get rid of every head to take over the station.

## General

rev-title = Revolutionaries
rev-description = Revolutionaries are among us.

rev-not-enough-ready-players = Not enough players readied up for the game. There were {$readyPlayersCount} players readied up out of {$minimumPlayers} needed. Can't start a Revolution.
rev-no-one-ready = No players readied up! Can't start a Revolution.
rev-no-heads = There were no Head Revolutionaries to be selected. Can't start a Revolution.

rev-won = The Head Revs survived and successfully seized control of the station.

rev-lost = Command survived and killed all of the Head Revs.

rev-stalemate = All of the Head Revs and Command died. It's a draw.

rev-reverse-stalemate = Both Command and Head Revs survived.

rev-headrev-count = {$initialCount ->
    [one] There was one Head Revolutionary:
    *[other] There were {$initialCount} Head Revolutionaries:
}

rev-headrev-name-user = [color=#5e9cff]{$name}[/color] ([color=gray]{$username}[/color]) converted {$count} {$count ->
    [one] person
    *[other] people
}

rev-headrev-name = [color=#5e9cff]{$name}[/color] converted {$count} {$count ->
    [one] person
    *[other] people
}

## Deconverted window

rev-deconverted-title = Deconverted!
rev-deconverted-text =
    As the last headrev has died, the revolution is over.

    You are no longer a revolutionary, so be nice.
rev-deconverted-confirm = Confirm
