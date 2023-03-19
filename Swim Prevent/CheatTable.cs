﻿namespace Swim_Prevent {
    class CheatTable {

        // this is also fairly shitty, but helps, cba to get every single string in mcpe history
        public static string[] illegalStrings = {
            "nitr0",
            "horion",
            "lakeside",
            "ambrosial",
            "helix",
            "ascendancy",
            "cheat engine",
            "xodus",
            "lokiclient",
            "loki client",
            "moon client",
            "cheatengine",
            "zephyr",
            "zephyr client",
            "badman",
            "eternium",
            "packet client",
            "fadeaway",
            "rixcheats",
            "clicker",
            "horionclient",
            "cryptoclient",
            "swiftclient",
            "swift client",
            "auto clicker",
            "clicker",
            "nitr0 lite",
            "luconia",
            "strikeinjector",
            "fadedinjector",
            "bominjector",
            "crypto client",
            "bolt client",
            "Ambrosial Launcher",
            "AlphaLauncher Injector",
            "Brush Client",
            "B1TCH Client",
            "Eternium Client",
            "Flare Client",
            "Fate Injector",
            "Ghostly Client",
            "HelixPvP Injector",
            "Horion Injector",
            "Horion Client",
            "Hanzai Client",
            "ImEU Client",
            "LakeSide Client",
            "Moon Client",
            "Nitr0 Client",
            "OP Autoclicker",
            "NG Injector",
            "Quadrix Client",
            "Surge Client Launcher",
            "Ventile Client",
            "CND Client",
            "CND Authentication",
            "Ascendancy Client",
            "Sp0tify Client",
            "JarJar Client",
            "saka Client",
            "Crypto Client",
            "openprocess",
            "readprocess",
            "slinky",
        };

        // cheat tables (as I call them) are bad detections, but it doesn't hurt to have them
        public static string checkMD5(string md5) {
            return md5 switch {
                "4ca3c23042c6e7baa2171fe2c2243cd6" => "Horion 1.12",
                "09A637F677110149C6E43223EF77DAA7" => "Ascendancy.exe",
                "689AEAD0BDF3F68F3A5F1273CCE7ED04" => "Fake svhost",
                "9E6DE7C7EBD1A00C2F7DDEC78BA9403A" => "Fate Injector.exe",
                "8E20218DFEF733FFD8FA284D4E1BAF78" => "Old Onix Injector.exe",
                "E4759B2E6AFF7E4D18A02F8E1FE2223D" => "Onix Launcher.exe",
                "B91AB28DB07F131095929EBF7A0E6B8A" => "Onix.dll",
                "CACAAFEC50116B8120027954BAD9AFDD" => "Onix Injector.exe",
                "4D7BE1A6DAD181D0E42AFA7AC7D8A872" => "Helix.dll",
                "689C0AD4003F1FEAB8EC45B281489460" => "Helix Alpha.exe",
                "0EC153E4EABB1AA5DFE11FD16ED1EA23" => "Helix PvP Injector.exe",
                "EB44D5A1914C9C32EF9994F9C4F6188D" => "Vene Clicker.jar",
                "B77FCB0221E5EDF634FF3B7A9CB75937" => "Nitro 1.17.10",
                "E93E3856353AA90A2E93D6E2D626AFC1" => "Eternium 1.17.10",
                "F8508B90A8DEA540F5BD2D497932C71A" => "Xodus.exe",
                "7872E9B626775F63747FCDF6650F647E" => "Ambrosial",
                "C33B0FFC80E108ECFF0C3832A06A8EC6" => "Nitro 1.17.2",
                "EF279B341F62120E1F5ABCFF85B24541" => "Horion DLL 1.17.2",
                "18CB627B78DD3C81F67F4002B92EECBA" => "YaamiClient.dll 1.17.2",
                "021F85ACA44ED090DF93C241CB37DE1A" => "Anarchy_Client 1.17.2",
                "29212477DF769B364B5769F0A5506FE0" => "auto_updating_hooks 1.17.2/1.17.0",
                "70B08DD86F749C1D26296BD8060224FB" => "Nitro 1.17.0",
                "CFF9E3E67D55BFECADF0D3D5AE14B35C" => "Ambrosial_And_Zephyr 1.17.0",
                "42384237C8CA34C94C9753F6484397AB" => "Anarchy_Client 1.17.0",
                "0F84EFDB27BB7CDF6A27A4E0EC5CE19B" => "Nitro 1.16.221",
                "58BDB1920EBA082553A7F8F7D62CF9CF" => "Loki 1.16.221",
                "655DBF3A33CAE2EE1C0BC68B91C399EB" => "Moon_V0.3 1.16.221",
                "D82D15F63342377D9A2C9CA5CD479A2B" => "Strike 1.16.221",
                "D7259DDE5D8F36FF2246391FFFACF60F" => "Eternium 1.16.221/ 1.16.220",
                "8C10C62384D6D5DC33EDC28C127E6D8D" => "Eclipse 1.16.221",
                "AD5CE67AF55E471417E929AFDBD9AE9F" => "Autism 1.16.221",
                "3ADB1338EDCA48C8A1DCA71CF2D70B53" => "Wave 1.16.221",
                "8A184F8A9C3D3A9BFD26D1676643DD98" => "Nitro 1.16.220",
                "2AFEEC5FBB445DED2FAC959DF9AE6B6F" => "Eclipse_Client",
                "8506318AC79494C9F7047BF76ADF7E33" => "Quadrix.dll 1.16.220",
                "11B45786CF2A41009BCD53EE8BCB2E4F" => "Nitro 1.16.210",
                "348EE5AFB324BB1E8297ECEF396CBB84" => "Disguised Process Hacker Nitr0  1.16.210",
                "894135DF60D9370CDDC17D316EB40DCC" => "Disguised Reasource Hacker Nitr0  1.16.210",
                "4C6703D30F207377329FE92E5597C82A" => "Disguised Spotify Nitr0  1.16.210",
                "555125301AE860C13A1EADB8732AB447" => "Disguised Minecraft Launcher Nitr0  1.16.210",
                "235AA72B4FB4B2306ECE386B744A24C8" => "Coffe 1.16.210, Coffee 1.16.201",
                "DA8D630DE50A275D0319E48DF50D7BCC" => "Eternium 1.16.210",
                "E420CD70AAFA0CA42C6242E0F5EBBE8F" => "Nitro 1.16.201",
                "1F52A54D68CC984CD4F2FFD7A1E675C5" => "Fadeaway 1.16.201",
                "BA2B6A24AB8DB28CFE9D27F590B60616" => "BadManPublic 1.16.201",
                "0A414304FA0DDE93C6C7276A339566B0" => "V3CTER 1.16.201",
                "F9A70C5D744ADA0C4FFAB4C83600BFAC" => "RixCheets 1.16.201",
                "1987AAB4325441558D798D5D1DD31E60" => "PacketClient 1.16.201",
                "B3D680A7DB274ADE853BD64980553693" => "HorionDLL 1.16.201",
                "200B18C738DD5465F6C638428D6FA8DE" => "HorionDebugInjector 1.16.201",
                "81D6E71A75E590237041E38851756DBA" => "Lakeside 1.16.100",
                "E9CB88B026CE2F528017636222AF1251" => "Nitro 1.16.100",
                "D6CF5B18F80300BE621EDDD41F1425B0" => "Explorer 1.16.100, Distinct 1.16.100",
                "7ECFC8CD7455DD9998F7DAD88F2A8A9D" => "OP AutoClicker.exe",
                "9350C5CF61A4D3D68177FAD54ACFD87C" => "XMouseButtonControl.exe",
                "8FD172F85EE2111BB2C796F255DFCA77" => "7Clicker.jar",
                "77652D318A4E61F0A6D76028B75493A3" => "mouseclicker.exe",
                "6862F65BE14FD3CE88086EC79777DB6E" => "GS Auto Clicker.exe",
                "27D5A6C9274255CF89B38F28480EDCF0" => "Polr Clicker.exe",
                "64701AE13E815DFF419E73CF9D66F924" => "TheFastestMouseClicker.exe",
                "4F3CE2D1C1C63AD7D1F563A9FFD5B7BD" => "TheFastestMouseGroupClicker.exe",
                "2CE992ABD25F22DE9A9B737BC608CF89" => "Cheat Engine.exe",
                "84B67974390A284A9B50E1FB1848B8BF" => "Clumsy.exe",
                "A68EE5AFB324BO9E8297ECEF396CBP84" => "Ascendancy 1.17.10",
                "20B98DD86NI49C1D26296BOD8060224F" => "Ascendancy 1.17.2",
                "E16V3856393AD90A2E93D6E2D62NAFC1" => "Ascendancy 1.17.2 Lite",
                "9S1OE1B6267S5F63749FCDF6650V647E" => "Ascendancy 1.17.0",
                "1A05B925F9CB6AACE8E20226305F6D87" => "Packet Client Injector.exe",
                "C6CD45133F9D90973C57C568DFEE0D51" => "Packet Client DLL",
                "01BD9957DD4B0E580E6A0FA271667C9F" => "Packet Client Old DLL",
                "98B2109BCF941B4FBBAD01C45F9D4B88" => "Nitr0 lite",
                "867aee91cd59fe555b607d28fea4e9af" => "treor",
                "596b0f4684d45de83c204967c06e48a3" => "Ambrosial",
                "b365af317ae730a67c936f21432b9c71" => "Process Hacker 2.0",
                "ae0d569dd692dd8374b4e211f2f4c1bd" => "nitro 1.18",
                "7a9bb20aaf6bf6971c8d40a4fe3352e6" => "nitro",
                "1289463d7d8df7d9176068f59c2ef2d0" => "nitro",
                "401ed0badfe8bc5b1c846716214acb72" => "nitro lite",
                "a5a8a0c225982cc2e48250c77476d4bc" => "nitro",
                "9f68552aa09d850984788fa6697e240b" => "nitro",
                "34b4737f23d1545a345ffbbdff43c0eb" => "nitro",
                "bf0d96e4046134b854b5467fa365ef78" => "nitro",
                "d02140e2d65107f79ac52eea83698535" => "nitro",
                "45947390ad0391be18fc5e503f9cd66e" => "nitro",
                "2ce992abd25f22de9a9b737bc608cf89" => "Cheat Engine",
                "36730c5c7ccb78a132209d4ead01b649" => "Cheat Engine",
                "56b684a54088439ce969e27a4d1ae4f2" => "Cheat Engine",
                "f8c759f9a0b69169b84422cb2da1b984" => "Cheat Engine",
                "cce3849e2b180b5ea32bcd0dca8ae28c" => "Zoom Clicker",
                "352352b54a1054a7f3e304e2a533ab70" => "Lunar Clicker",
                "689aead0bdf3f68f3a5f1273cce7ed04" => "Fake SVHOST",
                "40a0b560ed87dbdb9cc7cf34a4dab203" => "Spotify Clicker",
                "5bfdbb28cc7fed82bf415edac9c9eb83" => "Slinky Clicker",
                _ => "clean",
            };
        }
    }
}
