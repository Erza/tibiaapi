using Tibia.Addresses;

namespace Tibia
{
    public partial class Version
    {
        public static void SetVersion854()
        {
            BattleList.Start = 0x635F70;
            BattleList.StepCreatures = 0xA8;
            BattleList.MaxCreatures = 250;
            BattleList.End = BattleList.Start + (BattleList.StepCreatures * BattleList.MaxCreatures);

            Client.StartTime = 0x7D66B8;
            Client.XTeaKey = 0x78F7EC;
            Client.SocketStruct = 0x78F7C0;
            Client.RecvPointer = 0x5B25DC;
            Client.SendPointer = 0x5B2608;
            Client.FrameRatePointer = 0x79399C;
            Client.FrameRateCurrentOffset = 0x60;
            Client.FrameRateLimitOffset = 0x58;
            Client.MultiClient = 0x5070B4;
            Client.Status = 0x792E50;
            Client.SafeMode = 0x78FC14;
            Client.FollowMode = Client.SafeMode + 4;
            Client.AttackMode = Client.FollowMode + 4;
            Client.ActionState = 0x792EB0;
            Client.ActionStateFreezer = 0x5182A4;
            Client.LastMSGText = 0x7D6928;
            Client.LastMSGAuthor = Client.LastMSGText - 0x28;
            Client.StatusbarText = 0x7D66D8;
            Client.StatusbarTime = Client.StatusbarText - 4;
            Client.ClickId = 0x792EF0;
            Client.ClickCount = Client.ClickId + 4;
            Client.ClickZ = Client.ClickId - 0x68;
            Client.SeeId = Client.ClickId + 12;
            Client.SeeCount = Client.SeeId + 4;
            Client.SeeZ = Client.SeeId - 0x68;
            Client.ClickContextMenuItemId = 0x792EFC;
            Client.ClickContextMenuItemGroundId = 0x792F00;
            Client.ClickContextMenuCreatureId = 0x792EF8;
            Client.LoginServerStart = 0x78A728;
            Client.StepLoginServer = 112;
            Client.DistancePort = 100;
            Client.MaxLoginServers = 10;
            Client.RSA = 0x5B2610;
            Client.LoginCharList = 0x792E04;
            Client.LoginCharListLength = 0x792E08;
            Client.LoginSelectedChar = 0x792E00;
            Client.GameWindowRectPointer = 0x64218C;
            Client.GameWindowBar = 0x7D66CC;
            Client.DatPointer = 0x78F80C;
            Client.EventTriggerPointer = 0x51A210;
            Client.DialogPointer = 0x6454F4;
            Client.DialogLeft = 0x14;
            Client.DialogTop = 0x18;
            Client.DialogWidth = 0x1C;
            Client.DialogHeight = 0x20;
            Client.DialogCaption = 0x50;
            Client.LastRcvPacket = 0x78AFA0;
            Client.DecryptCall = 0x45BBE5;
            Client.LoginAccountNum = 0;
            Client.LoginPassword = 0x792E0C;
            Client.LoginAccount = Client.LoginPassword + 32;
            Client.LoginPatch = 0;
            Client.LoginPatch2 = 0;
            Client.LoginPatchOrig = new byte[] { 0xE8, 0x0D, 0x1D, 0x09, 0x00 };
            Client.LoginPatchOrig2 = new byte[] { 0xE8, 0xC8, 0x15, 0x09, 0x00 };
            Client.ParserFunc = 0x45BBB0;
            Client.GetNextPacketCall = 0x45BBE5;
            Client.RecvStream = 0x78F7DC;

            Container.Start = 0x642C40;
            Container.StepContainer = 492;
            Container.StepSlot = 12;
            Container.MaxContainers = 16;
            Container.MaxStack = 100;
            Container.DistanceIsOpen = 0;
            Container.DistanceId = 4;
            Container.DistanceName = 16;
            Container.DistanceVolume = 48;
            Container.DistanceAmount = 56;
            Container.DistanceItemId = 60;
            Container.DistanceItemCount = 64;
            Container.End = Container.Start + (Container.MaxContainers * Container.StepContainer);

            ContextMenus.AddContextMenuPtr = 0x451BB0;
            ContextMenus.OnClickContextMenuPtr = 0x44E350;
            ContextMenus.OnClickContextMenuVf = 0x5B77F0;
            ContextMenus.AddSetOutfitContextMenu = 0x452AE2;
            ContextMenus.AddPartyActionContextMenu = 0x452981;
            ContextMenus.AddCopyNameContextMenu = 0x452B4A;
            ContextMenus.AddTradeWithContextMenu = 0x452759;
            ContextMenus.AddLookContextMenu = 0x45260F;

            Creature.DistanceId = 0;
            Creature.DistanceType = 3;
            Creature.DistanceName = 4;
            Creature.DistanceX = 36;
            Creature.DistanceY = 40;
            Creature.DistanceZ = 44;
            Creature.DistanceScreenOffsetHoriz = 48;
            Creature.DistanceScreenOffsetVert = 52;
            Creature.DistanceIsWalking = 76;
            Creature.DistanceWalkSpeed = 140;
            Creature.DistanceDirection = 80;
            Creature.DistanceIsVisible = 144;
            Creature.DistanceBlackSquare = 132;
            Creature.DistanceLight = 120;
            Creature.DistanceLightColor = 124;
            Creature.DistanceHPBar = 136;
            Creature.DistanceSkull = 148;
            Creature.DistanceParty = 152;
            Creature.DistanceWarIcon = 160;
            Creature.DistanceIsBlocking = 164;
            Creature.DistanceOutfit = 96;
            Creature.DistanceColorHead = 100;
            Creature.DistanceColorBody = 104;
            Creature.DistanceColorLegs = 108;
            Creature.DistanceColorFeet = 112;
            Creature.DistanceAddon = 116;

            DatItem.StepItems = 0x50;
            DatItem.Width = 0;
            DatItem.Height = 4;
            DatItem.MaxSizeInPixels = 8;
            DatItem.Layers = 12;
            DatItem.PatternX = 16;
            DatItem.PatternY = 20;
            DatItem.PatternDepth = 24;
            DatItem.Phase = 28;
            DatItem.Sprite = 32;
            DatItem.Flags = 36;
            DatItem.CanLookAt = 40;
            DatItem.WalkSpeed = 44;
            DatItem.TextLimit = 48;
            DatItem.LightRadius = 52;
            DatItem.LightColor = 56;
            DatItem.ShiftX = 60;
            DatItem.ShiftY = 64;
            DatItem.WalkHeight = 68;
            DatItem.Automap = 72;
            DatItem.LensHelp = 76;

            DrawItem.DrawItemFunc = 0x4B1110;

            DrawSkin.DrawSkinFunc = 0x4B4DA0;

            Hotkey.SendAutomaticallyStart = 0x78FE10;
            Hotkey.SendAutomaticallyStep = 0x01;
            Hotkey.TextStart = 0x78FE38;
            Hotkey.TextStep = 0x100;
            Hotkey.ObjectStart = 0x78FD80;
            Hotkey.ObjectStep = 0x04;
            Hotkey.ObjectUseTypeStart = 0x78FC60;
            Hotkey.ObjectUseTypeStep = 0x04;
            Hotkey.MaxHotkeys = 36;

            Map.MapPointer = 0x64A048;
            Map.StepTile = 168;
            Map.StepTileObject = 12;
            Map.DistanceTileObjectCount = 0;
            Map.DistanceTileObjects = 4;
            Map.DistanceObjectId = 0;
            Map.DistanceObjectData = 4;
            Map.DistanceObjectDataEx = 8;
            Map.MaxTileObjects = 10;
            Map.MaxX = 18;
            Map.MaxY = 14;
            Map.MaxZ = 8;
            Map.MaxTiles = 2016;
            Map.ZAxisDefault = 7;
            Map.NameSpy1 = 0x4ED979;
            Map.NameSpy2 = 0x4ED983;
            Map.NameSpy1Default = 19061;
            Map.NameSpy2Default = 16501;
            Map.LevelSpy1 = 0x4EF82A;
            Map.LevelSpy2 = 0x4EF92F;
            Map.LevelSpy3 = 0x4EF9B0;
            Map.LevelSpyPtr = 0x64218C;
            Map.LevelSpyAdd1 = 28;
            Map.LevelSpyAdd2 = 0x2A88;
            Map.LevelSpyDefault = new byte[] { 0x89, 0x86, 0x88, 0x2A, 0x00, 0x00 };
            Map.FullLightNop = 0x4E6119;
            Map.FullLightAdr = 0x4E611C;
            Map.FullLightNopDefault = new byte[] { 0x7E, 0x05 };
            Map.FullLightNopEdited = new byte[] { 0x90, 0x90 };
            Map.FullLightAdrDefault = 0x80;
            Map.FullLightAdrEdited = 0xFF;

            Player.Experience = 0x635F04;
            Player.Flags = Player.Experience - 108;
            Player.Id = Player.Experience + 12;
            Player.Health = Player.Experience + 8;
            Player.HealthMax = Player.Experience + 4;
            Player.Level = Player.Experience - 4;
            Player.MagicLevel = Player.Experience - 8;
            Player.LevelPercent = Player.Experience - 12;
            Player.MagicLevelPercent = Player.Experience - 16;
            Player.Mana = Player.Experience - 20;
            Player.ManaMax = Player.Experience - 24;
            Player.Soul = Player.Experience - 28;
            Player.Stamina = Player.Experience - 32;
            Player.Capacity = Player.Experience - 36;
            Player.FistPercent = 0x635E9C;
            Player.ClubPercent = Player.FistPercent + 4;
            Player.SwordPercent = Player.FistPercent + 8;
            Player.AxePercent = Player.FistPercent + 12;
            Player.DistancePercent = Player.FistPercent + 16;
            Player.ShieldingPercent = Player.FistPercent + 20;
            Player.FishingPercent = Player.FistPercent + 24;
            Player.Fist = Player.FistPercent + 28;
            Player.Club = Player.FistPercent + 32;
            Player.Sword = Player.FistPercent + 36;
            Player.Axe = Player.FistPercent + 40;
            Player.Distance = Player.FistPercent + 44;
            Player.Shielding = Player.FistPercent + 48;
            Player.Fishing = Player.FistPercent + 52;
            Player.SlotHead = 0x642BC8;
            Player.SlotNeck = Player.SlotHead + 12;
            Player.SlotBackpack = Player.SlotHead + 24;
            Player.SlotArmor = Player.SlotHead + 36;
            Player.SlotRight = Player.SlotHead + 48;
            Player.SlotLeft = Player.SlotHead + 60;
            Player.SlotLegs = Player.SlotHead + 72;
            Player.SlotFeet = Player.SlotHead + 84;
            Player.SlotRing = Player.SlotHead + 96;
            Player.SlotAmmo = Player.SlotHead + 108;
            Player.MaxSlots = 11;
            Player.DistanceSlotCount = 4;
            Player.CurrentTileToGo = 0x635F18;
            Player.TilesToGo = 0x635F1C;
            Player.GoToX = Player.Experience + 80;
            Player.GoToY = Player.GoToX - 4;
            Player.GoToZ = Player.GoToX - 8;
            Player.RedSquare = 0x635EDC;
            Player.GreenSquare = Player.RedSquare - 4;
            Player.WhiteSquare = Player.GreenSquare - 8;
            Player.AccessN = 0;
            Player.AccessS = 0;
            Player.TargetId = Player.RedSquare;
            Player.TargetBattlelistId = Player.TargetId - 8;
            Player.TargetBattlelistType = Player.TargetId - 5;
            Player.TargetType = Player.TargetId + 3;
            Player.Z = 0x645530;

            TextDisplay.PrintName = 0x4F0993;
            TextDisplay.PrintFPS = 0x459AC8;
            TextDisplay.ShowFPS = 0x633BB4;
            TextDisplay.PrintTextFunc = 0x4B0550;
            TextDisplay.NopFPS = 0x459A04;

            Vip.Start = 0x633C30;
            Vip.StepPlayers = 0x2C;
            Vip.MaxPlayers = 200;
            Vip.DistanceId = 0;
            Vip.DistanceName = 4;
            Vip.DistanceStatus = 34;
            Vip.DistanceIcon = 40;
            Vip.End = Vip.Start + (Vip.StepPlayers * Vip.MaxPlayers);
        }
    }
}