// SPDX-FileCopyrightText: 2024 SlamBamActionman <83650252+SlamBamActionman@users.noreply.github.com>
// SPDX-FileCopyrightText: 2024 sleepyyapril <flyingkarii@gmail.com>
// SPDX-FileCopyrightText: 2025 sleepyyapril <123355664+sleepyyapril@users.noreply.github.com>
//
// SPDX-License-Identifier: AGPL-3.0-or-later AND MIT

using Content.Server.Atmos.Components;
using Content.Server.Atmos.EntitySystems;
using Content.Shared.EntityEffects;
using JetBrains.Annotations;
using Robust.Shared.Prototypes;

namespace Content.Server.EntityEffects.Effects
{
    [UsedImplicitly]
    public sealed partial class ExtinguishReaction : EntityEffect
    {
        /// <summary>
        ///     Amount of firestacks reduced.
        /// </summary>
        [DataField]
        public float FireStacksAdjustment = -1.5f;

        protected override string? ReagentEffectGuidebookText(IPrototypeManager prototype, IEntitySystemManager entSys)
            => Loc.GetString("reagent-effect-guidebook-extinguish-reaction", ("chance", Probability));

        public override void Effect(EntityEffectBaseArgs args)
        {
            if (!args.EntityManager.TryGetComponent(args.TargetEntity, out FlammableComponent? flammable)) return;

            var flammableSystem = args.EntityManager.System<FlammableSystem>();
            flammableSystem.Extinguish(args.TargetEntity, flammable);
            if (args is EntityEffectReagentArgs reagentArgs)
            {
                flammableSystem.AdjustFireStacks(reagentArgs.TargetEntity, FireStacksAdjustment * (float) reagentArgs.Quantity, flammable);
            } else
            {
                flammableSystem.AdjustFireStacks(args.TargetEntity, FireStacksAdjustment, flammable);
            }
        }
    }
}
