// SPDX-FileCopyrightText: 2022 Rane <60792108+Elijahrane@users.noreply.github.com>
// SPDX-FileCopyrightText: 2023 KP <13428215+nok-ko@users.noreply.github.com>
// SPDX-FileCopyrightText: 2023 metalgearsloth <31366439+metalgearsloth@users.noreply.github.com>
// SPDX-FileCopyrightText: 2024 Skubman <ba.fallaria@gmail.com>
// SPDX-FileCopyrightText: 2024 slarticodefast <161409025+slarticodefast@users.noreply.github.com>
// SPDX-FileCopyrightText: 2024 sleepyyapril <flyingkarii@gmail.com>
// SPDX-FileCopyrightText: 2025 sleepyyapril <123355664+sleepyyapril@users.noreply.github.com>
//
// SPDX-License-Identifier: AGPL-3.0-or-later AND MIT

using System.Numerics;

namespace Content.Shared.Throwing;

[ByRefEvent]
public struct BeforeThrowEvent
{
    public BeforeThrowEvent(EntityUid itemUid, Vector2 direction, float throwSpeed,  EntityUid playerUid)
    {
        ItemUid = itemUid;
        Direction = direction;
        ThrowSpeed = throwSpeed;
        PlayerUid = playerUid;
    }

    public EntityUid ItemUid { get; set; }
    public Vector2 Direction { get; }
    public float ThrowSpeed { get; set;}
    public EntityUid PlayerUid { get; }

    public bool Cancelled = false;
}

[ByRefEvent]
public struct BeforeGettingThrownEvent
{
    public BeforeGettingThrownEvent(EntityUid itemUid, Vector2 direction, float throwSpeed,  EntityUid playerUid)
    {
        ItemUid = itemUid;
        Direction = direction;
        ThrowSpeed = throwSpeed;
        PlayerUid = playerUid;
    }

    public EntityUid ItemUid { get; set; }
    public Vector2 Direction { get; }
    public float ThrowSpeed { get; set;}
    public EntityUid PlayerUid { get; }

    public bool Cancelled = false;
}
