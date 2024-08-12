﻿using BepInEx.Configuration;
using HANDReturns.Modules;
using HANDReturns.Modules.Characters;
using HANDReturns.Survivors.HANDReturns.Components;
using HANDReturns.Survivors.HANDReturns.SkillStates;
using RoR2;
using RoR2.Skills;
using System.Collections.Generic;
using UnityEngine;

namespace HANDReturns.Survivors.HANDReturns {
    public class HANDReturnsSurvivor : SurvivorBase<HANDReturnsSurvivor> {
        public override string assetBundleName => "handybundle";

        public override string bodyName => "HANDReturnsBody";

        public override string masterName => "HANDReturnsMonsterMaster";

        public override string modelPrefabName => "mdlHANDReturns";

        public override string displayPrefabName => "HANDReturnsDisplay";

        public const string HANDReturns_PREFIX = HANDReturnsPlugin.DEVELOPER_PREFIX + "_HANDRETURNS_";

        //used when registering your survivor's language tokens
        public override string survivorTokenPrefix => HANDReturns_PREFIX;
        
        public override BodyInfo bodyInfo => new BodyInfo {
            bodyName = bodyName,
            bodyNameToken = HANDReturns_PREFIX + "NAME",
            subtitleNameToken = HANDReturns_PREFIX + "SUBTITLE",

            characterPortrait = assetBundle.LoadAsset<Texture>("texHANDReturnsIcon"),
            bodyColor = new Color (0.5f, 0.68f, 0.70f),
            sortPosition = 4,

            crosshair = LegacyResourcesAPI.Load<GameObject>("prefabs/crosshair/captaincrosshair"),
            podPrefab = LegacyResourcesAPI.Load<GameObject>("Prefabs/NetworkedObjects/RoboCratePod"),

            damage = 13.5f,
            damageGrowth = 13.5f * 0.2f,

            maxHealth = 320f,
            healthGrowth = 320f * 0.3f,

            healthRegen = 1.2f,
            regenGrowth = 1.2f * 0.2f,
            
            armor = 14f,
            armorGrowth = 14f * 0.2f,

            jumpCount = 1,
        };

        #region Renderer infos
        public override CustomRendererInfo[] customRendererInfos => new CustomRendererInfo[] {
                new CustomRendererInfo {
                    childName = "Crotch",
                    material = assetBundle.LoadMaterial("matHAND"),
                },
                new CustomRendererInfo {
                    childName = "Torso",
                    material = assetBundle.LoadMaterial("matHAND"),
                },
                new CustomRendererInfo {
                    childName = "Eye",
                    material = assetBundle.LoadMaterial("matHAND"),
                },
                new CustomRendererInfo {
                    childName = "Hat",
                    material = assetBundle.LoadMaterial("matHat"),
                },
                new CustomRendererInfo {
                    childName = "Head",
                    material = assetBundle.LoadMaterial("matHAND"),
                },
                new CustomRendererInfo {
                    childName = "AntennaBig",
                    material = assetBundle.LoadMaterial("matHAND"),
                },
                new CustomRendererInfo {
                    childName = "AntennaSmall",
                    material = assetBundle.LoadMaterial("matHAND"),
                },
                new CustomRendererInfo {
                    childName = "Smokestack",
                    material = assetBundle.LoadMaterial("matHAND"),
                },
                new CustomRendererInfo {
                    childName = "DRK",
                    material = assetBundle.LoadMaterial("matHAND"),
                },
                new CustomRendererInfo {
                    childName = "ShoulderBladeR",
                    material = assetBundle.LoadMaterial("matHAND"),
                },
                new CustomRendererInfo {
                    childName = "ShoulderR",
                    material = assetBundle.LoadMaterial("matHAND"),
                },
                new CustomRendererInfo {
                    childName = "ElbowR",
                    material = assetBundle.LoadMaterial("matHAND"),
                },
                new CustomRendererInfo {
                    childName = "ForearmR",
                    material = assetBundle.LoadMaterial("matHAND"),
                },
                new CustomRendererInfo {
                    childName = "ArmPistonR",
                    material = assetBundle.LoadMaterial("matHAND"),
                },
                new CustomRendererInfo {
                    childName = "WristR",
                    material = assetBundle.LoadMaterial("matHAND"),
                },
                new CustomRendererInfo {
                    childName = "ShoulderBladeL",
                    material = assetBundle.LoadMaterial("matHAND"),
                },
                new CustomRendererInfo {
                    childName = "ShoulderL",
                    material = assetBundle.LoadMaterial("matHAND"),
                },
                new CustomRendererInfo {
                    childName = "ElbowL",
                    material = assetBundle.LoadMaterial("matHAND"),
                },
                new CustomRendererInfo {
                    childName = "ForearmL",
                    material = assetBundle.LoadMaterial("matHAND"),
                },
                new CustomRendererInfo {
                    childName = "ArmPistonL",
                    material = assetBundle.LoadMaterial("matHAND"),
                },
                new CustomRendererInfo {
                    childName = "WristL",
                    material = assetBundle.LoadMaterial("matHAND"),
                },
                new CustomRendererInfo {
                    childName = "ThighR",
                    material = assetBundle.LoadMaterial("matHAND"),
                },
                new CustomRendererInfo {
                    childName = "KneeR",
                    material = assetBundle.LoadMaterial("matHAND"),
                },
                new CustomRendererInfo {
                    childName = "LegPistonR",
                    material = assetBundle.LoadMaterial("matHAND"),
                },
                new CustomRendererInfo {
                    childName = "CalfR",
                    material = assetBundle.LoadMaterial("matHAND"),
                },
                new CustomRendererInfo {
                    childName = "FeetR",
                    material = assetBundle.LoadMaterial("matHAND"),
                },
                new CustomRendererInfo {
                    childName = "ThighL",
                    material = assetBundle.LoadMaterial("matHAND"),
                },
                new CustomRendererInfo {
                    childName = "KneeL",
                    material = assetBundle.LoadMaterial("matHAND"),
                },
                new CustomRendererInfo {
                    childName = "LegPistonL",
                    material = assetBundle.LoadMaterial("matHAND"),
                },
                new CustomRendererInfo {
                    childName = "CalfL",
                },
                new CustomRendererInfo {
                    childName = "FeetL",
                },
                new CustomRendererInfo {
                    childName = "IndexProximalL",
                },
                new CustomRendererInfo {
                    childName = "IndexDistalL",
                },
                new CustomRendererInfo {
                    childName = "MiddleProximalL",
                },
                new CustomRendererInfo {
                    childName = "MiddleDistalL",
                },
                new CustomRendererInfo {
                    childName = "ThumbProximalL",
                },
                new CustomRendererInfo {
                    childName = "ThumbDistalL",
                },
                new CustomRendererInfo {
                    childName = "IndexProximalR",
                },
                new CustomRendererInfo {
                    childName = "IndexDistalR",
                },
                new CustomRendererInfo {
                    childName = "MiddleProximalR",
                },
                new CustomRendererInfo {
                    childName = "MiddleDistalR",
                },
                new CustomRendererInfo {
                    childName = "ThumbProximalR",
                },
                new CustomRendererInfo {
                    childName = "ThumbDistalR",
                },
        };
        #endregion

        public override UnlockableDef characterUnlockableDef => HANDReturnsUnlockables.characterUnlockableDef;
        
        public override ItemDisplaysBase itemDisplays => new HANDReturnsItemDisplays();
        
        public override AssetBundle assetBundle { get; protected set; }
        
        public override GameObject bodyPrefab { get; protected set; }
        
        public override CharacterBody prefabCharacterBody { get; protected set; }
        
        public override GameObject characterModelObject { get; protected set; }
        
        public override CharacterModel prefabCharacterModel { get; protected set; }
        
        public override GameObject displayPrefab { get; protected set; }
        
        public override void Initialize() => base.Initialize();

        public override void InitializeCharacter() {
            HANDReturnsUnlockables.Init();

            base.InitializeCharacter();

            HANDReturnsConfig.Init();
            HANDReturnsStates.Init();
            HANDReturnsTokens.Init();

            HANDReturnsAssets.Init(assetBundle);
            HANDReturnsBuffs.Init(assetBundle);

            InitializeEntityStateMachines();
            InitializeSkills();
            InitializeSkins();
            InitializeCharacterMaster();

            AdditionalBodySetup();

            AddHooks();
        }

        private void AdditionalBodySetup() {
            AddHitboxes();
            bodyPrefab.AddComponent<HANDReturnsWeaponComponent>();
            //bodyPrefab.AddComponent<HuntressTrackerComopnent>();
        }

        public void AddHitboxes() {
            //example of how to create a HitBoxGroup. see summary for more details
            Prefabs.SetupHitBoxGroup(characterModelObject, "PunchGroup", "PunchHitbox");
            Prefabs.SetupHitBoxGroup(characterModelObject, "HammerGroup", "HammerHitbox");
        }

        public override void InitializeEntityStateMachines() {
            Prefabs.ClearEntityStateMachines(bodyPrefab);

            Prefabs.AddMainEntityStateMachine(bodyPrefab, "Body", typeof(EntityStates.GenericCharacterMain), typeof(EntityStates.SpawnTeleporterState));
            //if you set up a custom main characterstate, set it up here
                //don't forget to register custom entitystates in your HANDReturnsStates.cs

            Prefabs.AddEntityStateMachine(bodyPrefab, "Weapon");
            Prefabs.AddEntityStateMachine(bodyPrefab, "Weapon2");
        }

        #region skills
        public override void InitializeSkills() {
            Skills.ClearGenericSkills(bodyPrefab);

            AddPrimarySkills();
            AddSecondarySkills();
            AddUtiitySkills();
            AddSpecialSkills();
        }
        
        //if this is your first look at skilldef creation, take a look at Secondary first
        private void AddPrimarySkills() {
            Skills.CreateGenericSkillWithSkillFamily(bodyPrefab, SkillSlot.Primary);

            //the primary skill is created using a constructor for a typical primary
            //it is also a SteppedSkillDef. Custom Skilldefs are very useful for custom behaviors related to casting a skill. see ror2's different skilldefs for reference
            SteppedSkillDef primaryPunchDef = Skills.CreateSkillDef<SteppedSkillDef>(new SkillDefInfo (
                    "HANDReturnsPunch",
                    HANDReturns_PREFIX + "PRIMARY_PUNCH_NAME",
                    HANDReturns_PREFIX + "PRIMARY_PUNCH_DESCRIPTION",
                    assetBundle.LoadAsset<Sprite>("texPrimaryPunchIcon"),
                    new EntityStates.SerializableEntityStateType(typeof(SlashCombo)),
                    "Weapon",
                    true
                ));
            //custom Skilldefs can have additional fields that you can set manually
            primaryPunchDef.stepCount = 2;
            primaryPunchDef.stepGraceDuration = 0.5f;

            Skills.AddPrimarySkills(bodyPrefab, primaryPunchDef);
        }

        private void AddSecondarySkills() {
            Skills.CreateGenericSkillWithSkillFamily(bodyPrefab, SkillSlot.Secondary);

            //here is a basic skill def with all fields accounted for
            SkillDef secondaryHealthDroneDef = Skills.CreateSkillDef(new SkillDefInfo
            {
                skillName = "HealthDrone",
                skillNameToken = HANDReturns_PREFIX + "SECONDARY_HEALTH_DRONE_NAME",
                skillDescriptionToken = HANDReturns_PREFIX + "SECONDARY_HEALTH_DRONE_DESCRIPTION",
                keywordTokens = new string[] { "KEYWORD_AGILE" },
                skillIcon = assetBundle.LoadAsset<Sprite>("texSecondaryHealthIcon"),

                activationState = new EntityStates.SerializableEntityStateType(typeof(Shoot)),
                activationStateMachineName = "Weapon2",
                interruptPriority = EntityStates.InterruptPriority.Skill,

                baseRechargeInterval = 1f,
                baseMaxStock = 10,

                rechargeStock = 1,
                requiredStock = 1,
                stockToConsume = 1,

                resetCooldownTimerOnUse = false,
                fullRestockOnAssign = true,
                dontAllowPastMaxStocks = false,
                mustKeyPress = false,
                beginSkillCooldownOnSkillEnd = true,

                isCombatSkill = false,
                canceledFromSprinting = false,
                cancelSprintingOnActivation = false,
                forceSprintDuringState = false,

            });

            SkillDef secondarySpeedDroneDef = Skills.CreateSkillDef(new SkillDefInfo {
                skillName = "SpeedDrone",
                skillNameToken = HANDReturns_PREFIX + "SECONDARY_SPEED_DRONE_NAME",
                skillDescriptionToken = HANDReturns_PREFIX + "SECONDARY_SPEED_DRONE_DESCRIPTION",
                skillIcon = assetBundle.LoadAsset<Sprite>("texSecondarySpeedIcon"),

                activationState = new EntityStates.SerializableEntityStateType(typeof(Shoot)),
                activationStateMachineName = "Weapon2",
                interruptPriority = EntityStates.InterruptPriority.Skill,

                baseRechargeInterval = 1f,
                baseMaxStock = 10,

                rechargeStock = 1,
                requiredStock = 1,
                stockToConsume = 1,

                resetCooldownTimerOnUse = false,
                fullRestockOnAssign = true,
                dontAllowPastMaxStocks = false,
                mustKeyPress = false,
                beginSkillCooldownOnSkillEnd = true,

                isCombatSkill = true,
                canceledFromSprinting = false,
                cancelSprintingOnActivation = true,
                forceSprintDuringState = false,

            });

            SkillDef secondaryBlastDroneDef = Skills.CreateSkillDef(new SkillDefInfo {
                skillName = "BlastDrone",
                skillNameToken = HANDReturns_PREFIX + "SECONDARY_BLAST_DRONE_NAME",
                skillDescriptionToken = HANDReturns_PREFIX + "SECONDARY_BLAST_DRONE_DESCRIPTION",
                skillIcon = assetBundle.LoadAsset<Sprite>("texSecondaryBlastIcon"),

                activationState = new EntityStates.SerializableEntityStateType(typeof(Shoot)),
                activationStateMachineName = "Weapon2",
                interruptPriority = EntityStates.InterruptPriority.Skill,

                baseRechargeInterval = 1f,
                baseMaxStock = 5,

                rechargeStock = 1,
                requiredStock = 1,
                stockToConsume = 1,

                resetCooldownTimerOnUse = false,
                fullRestockOnAssign = true,
                dontAllowPastMaxStocks = false,
                mustKeyPress = false,
                beginSkillCooldownOnSkillEnd = true,

                isCombatSkill = true,
                canceledFromSprinting = true,
                cancelSprintingOnActivation = true,
                forceSprintDuringState = false,

            });

            Skills.AddSecondarySkills(bodyPrefab, secondaryHealthDroneDef);
            Skills.AddSecondarySkills(bodyPrefab, secondarySpeedDroneDef);
            Skills.AddSecondarySkills(bodyPrefab, secondaryBlastDroneDef);
        }

        private void AddUtiitySkills() {
            Skills.CreateGenericSkillWithSkillFamily(bodyPrefab, SkillSlot.Utility);

            //here's a skilldef of a typical movement skill.
            SkillDef utilitySkillDef1 = Skills.CreateSkillDef(new SkillDefInfo {
                skillName = "HANDReturnsOverclock",
                skillNameToken = HANDReturns_PREFIX + "UTILITY_OVERCLOCK_NAME",
                skillDescriptionToken = HANDReturns_PREFIX + "UTILITY_OVERCLOCK_DESCRIPTION",
                skillIcon = assetBundle.LoadAsset<Sprite>("texUtilityOverclockIcon"),

                activationState = new EntityStates.SerializableEntityStateType(typeof(Roll)),
                activationStateMachineName = "Body",
                interruptPriority = EntityStates.InterruptPriority.PrioritySkill,

                baseRechargeInterval = 4f,
                baseMaxStock = 1,

                rechargeStock = 1,
                requiredStock = 1,
                stockToConsume = 1,

                resetCooldownTimerOnUse = false,
                fullRestockOnAssign = true,
                dontAllowPastMaxStocks = false,
                mustKeyPress = false,
                beginSkillCooldownOnSkillEnd = false,

                isCombatSkill = false,
                canceledFromSprinting = false,
                cancelSprintingOnActivation = false,
                forceSprintDuringState = true,
            });

            Skills.AddUtilitySkills(bodyPrefab, utilitySkillDef1);
        }

        private void AddSpecialSkills() {
            Skills.CreateGenericSkillWithSkillFamily(bodyPrefab, SkillSlot.Special);

            //a basic skill. some fields are omitted and will just have default values
            SkillDef specialSkillDef1 = Skills.CreateSkillDef(new SkillDefInfo {
                skillName = "HANDReturnsHammer",
                skillNameToken = HANDReturns_PREFIX + "SPECIAL_HAMMER_NAME",
                skillDescriptionToken = HANDReturns_PREFIX + "SPECIAL_HAMMER_DESCRIPTION",
                skillIcon = assetBundle.LoadAsset<Sprite>("texSpecialHammerIcon"),

                activationState = new EntityStates.SerializableEntityStateType(typeof(ThrowBomb)),
                //setting this to the "weapon2" EntityStateMachine allows us to cast this skill at the same time as the primary, which is set to the "weapon" EntityStateMachine
                activationStateMachineName = "Weapon2", interruptPriority = EntityStates.InterruptPriority.Skill,

                baseRechargeInterval = 10f,
                baseMaxStock = 1,
                stockToConsume = 1,

                isCombatSkill = true,
                mustKeyPress = false,
            });

            Skills.AddSpecialSkills(bodyPrefab, specialSkillDef1);
        }
        #endregion skills
        
        #region skins
        public override void InitializeSkins() {
            ModelSkinController skinController = prefabCharacterModel.gameObject.AddComponent<ModelSkinController>();
            ChildLocator childLocator = prefabCharacterModel.GetComponent<ChildLocator>();

            CharacterModel.RendererInfo[] defaultRendererinfos = prefabCharacterModel.baseRendererInfos;

            List<SkinDef> skins = new List<SkinDef>();

            #region DefaultSkin
            //this creates a SkinDef with all default fields
            SkinDef defaultSkin = Skins.CreateSkinDef("DEFAULT_SKIN",
                assetBundle.LoadAsset<Sprite>("texMainSkin"),
                defaultRendererinfos,
                prefabCharacterModel.gameObject);

            //these are your Mesh Replacements. The order here is based on your CustomRendererInfos from earlier
                //pass in meshes as they are named in your assetbundle
            //currently not needed as with only 1 skin they will simply take the default meshes
                //uncomment this when you have another skin
            //defaultSkin.meshReplacements = Modules.Skins.getMeshReplacements(assetBundle, defaultRendererinfos,
            //    "meshHANDReturnsSword",
            //    "meshHANDReturnsGun",
            //    "meshHANDReturns");

            //add new skindef to our list of skindefs. this is what we'll be passing to the SkinController
            skins.Add(defaultSkin);
            #endregion

            //uncomment this when you have a mastery skin
            #region MasterySkin
            
            ////creating a new skindef as we did before
            //SkinDef masterySkin = Modules.Skins.CreateSkinDef(HANDReturns_PREFIX + "MASTERY_SKIN_NAME",
            //    assetBundle.LoadAsset<Sprite>("texMasteryAchievement"),
            //    defaultRendererinfos,
            //    prefabCharacterModel.gameObject,
            //    HANDReturnsUnlockables.masterySkinUnlockableDef);

            ////adding the mesh replacements as above. 
            ////if you don't want to replace the mesh (for example, you only want to replace the material), pass in null so the order is preserved
            //masterySkin.meshReplacements = Modules.Skins.getMeshReplacements(assetBundle, defaultRendererinfos,
            //    "meshHANDReturnsSwordAlt",
            //    null,//no gun mesh replacement. use same gun mesh
            //    "meshHANDReturnsAlt");

            ////masterySkin has a new set of RendererInfos (based on default rendererinfos)
            ////you can simply access the RendererInfos' materials and set them to the new materials for your skin.
            //masterySkin.rendererInfos[0].defaultMaterial = assetBundle.LoadMaterial("matHANDReturnsAlt");
            //masterySkin.rendererInfos[1].defaultMaterial = assetBundle.LoadMaterial("matHANDReturnsAlt");
            //masterySkin.rendererInfos[2].defaultMaterial = assetBundle.LoadMaterial("matHANDReturnsAlt");

            ////here's a barebones example of using gameobjectactivations that could probably be streamlined or rewritten entirely, truthfully, but it works
            //masterySkin.gameObjectActivations = new SkinDef.GameObjectActivation[]
            //{
            //    new SkinDef.GameObjectActivation
            //    {
            //        gameObject = childLocator.FindChildGameObject("GunModel"),
            //        shouldActivate = false,
            //    }
            //};
            ////simply find an object on your child locator you want to activate/deactivate and set if you want to activate/deacitvate it with this skin

            //skins.Add(masterySkin);
            
            #endregion

            skinController.skins = skins.ToArray();
        }
        #endregion skins

        //Character Master is what governs the AI of your character when it is not controlled by a player (artifact of vengeance, goobo)
        public override void InitializeCharacterMaster() {
            //you must only do one of these. adding duplicate masters breaks the game.

            //if you're lazy or prototyping you can simply copy the AI of a different character to be used
            //Modules.Prefabs.CloneDopplegangerMaster(bodyPrefab, masterName, "Merc");

            //how to set up AI in code
            HANDReturnsAI.Init(bodyPrefab, masterName);

            //how to load a master set up in unity, can be an empty gameobject with just AISkillDriver components
            //assetBundle.LoadMaster(bodyPrefab, masterName);
        }

        private void AddHooks() => R2API.RecalculateStatsAPI.GetStatCoefficients += RecalculateStatsAPI_GetStatCoefficients;

        private void RecalculateStatsAPI_GetStatCoefficients(CharacterBody sender, R2API.RecalculateStatsAPI.StatHookEventArgs args) {
            if (sender.HasBuff(HANDReturnsBuffs.armorBuff))
                args.armorAdd += 300;
        }
    }
}