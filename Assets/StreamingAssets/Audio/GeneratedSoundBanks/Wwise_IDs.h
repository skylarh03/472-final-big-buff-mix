/////////////////////////////////////////////////////////////////////////////////////////////////////
//
// Audiokinetic Wwise generated include file. Do not edit.
//
/////////////////////////////////////////////////////////////////////////////////////////////////////

#ifndef __WWISE_IDS_H__
#define __WWISE_IDS_H__

#include <AK/SoundEngine/Common/AkTypes.h>

namespace AK
{
    namespace EVENTS
    {
        static const AkUniqueID FORCESET_TIMEOFDAY_DAY = 1866332930U;
        static const AkUniqueID FORCESET_TIMEOFDAY_NIGHT = 1700992294U;
        static const AkUniqueID GAMESTART = 4058101365U;
        static const AkUniqueID HARDSTOP_DAY_MELODY_01 = 3095270486U;
        static const AkUniqueID HARDSTOP_DAY_MELODY_02 = 3095270485U;
        static const AkUniqueID HARDSTOP_DAY_MELODY_03 = 3095270484U;
        static const AkUniqueID PLAY_COMBAT_MUSIC = 3155474038U;
        static const AkUniqueID PLAY_DAY_MELODY_01 = 2117048067U;
        static const AkUniqueID PLAY_DAY_MELODY_02 = 2117048064U;
        static const AkUniqueID PLAY_DAY_MELODY_03 = 2117048065U;
        static const AkUniqueID PLAY_DIALOGUELOOP = 3352186862U;
        static const AkUniqueID PLAY_EMITTER_CROWD = 876452814U;
        static const AkUniqueID PLAY_EMITTER_SEALS = 318432063U;
        static const AkUniqueID PLAY_EMITTER_WATERFALL = 1611901679U;
        static const AkUniqueID PLAY_MONOLOGUE = 3208730517U;
        static const AkUniqueID PLAY_NIGHT_ARP = 76591114U;
        static const AkUniqueID PLAY_NIGHT_COUNTERMELODY = 1057837593U;
        static const AkUniqueID PLAY_NIGHT_MELODY = 2032307683U;
        static const AkUniqueID PLAY_STINGER_ENTERCOMBAT = 1109613271U;
        static const AkUniqueID PLAY_STINGER_EXITCOMBAT = 4268407383U;
        static const AkUniqueID PLAY_STINGER_ITEM_COLLECTION = 2049735205U;
        static const AkUniqueID PLAY_STINGER_PLAYER_GOTOBED = 2730318483U;
        static const AkUniqueID PLAY_UI_BUTTON = 43599987U;
        static const AkUniqueID SET_COMBATTENSION_HIGH = 1092604815U;
        static const AkUniqueID SET_COMBATTENSION_LOW = 2957603579U;
        static const AkUniqueID SET_GAMESTATE_BEACH = 3248879779U;
        static const AkUniqueID SET_GAMESTATE_COMBAT = 2438311370U;
        static const AkUniqueID SET_GAMESTATE_EXPLORATION = 1544625833U;
        static const AkUniqueID SET_GAMESTATE_TOWN = 2995852670U;
        static const AkUniqueID SET_INSIDE_FALSE = 3937140874U;
        static const AkUniqueID SET_INSIDE_TRUE = 4081663009U;
        static const AkUniqueID SET_RTPC_RAIN_0 = 3483057933U;
        static const AkUniqueID SET_RTPC_RAIN_100 = 1490057868U;
        static const AkUniqueID SET_TENSION_HIGH_33PERCENT = 2122435667U;
        static const AkUniqueID SET_TIMEOFDAY_DAY = 753784447U;
        static const AkUniqueID SET_TIMEOFDAY_NIGHT = 71469835U;
        static const AkUniqueID SET_UNDERWATER_FALSE = 2424015369U;
        static const AkUniqueID SET_UNDERWATER_TRUE = 1703876944U;
        static const AkUniqueID STARTAMBIENCE = 1316191055U;
        static const AkUniqueID STOP_ALL = 452547817U;
        static const AkUniqueID STOP_DAY_MELODY_01 = 1359923209U;
        static const AkUniqueID STOP_DAY_MELODY_02 = 1359923210U;
        static const AkUniqueID STOP_DAY_MELODY_03 = 1359923211U;
        static const AkUniqueID STOP_NIGHT_ARP = 2392457068U;
        static const AkUniqueID STOP_NIGHT_MELODY_01 = 252313125U;
        static const AkUniqueID STOP_NIGHT_MELODY_02 = 252313126U;
        static const AkUniqueID STOP_NIGHT_MELODY_03 = 252313127U;
        static const AkUniqueID STOP_NIGHT_MELODY_04 = 252313120U;
    } // namespace EVENTS

    namespace STATES
    {
        namespace COMBATTENSION
        {
            static const AkUniqueID GROUP = 1069915969U;

            namespace STATE
            {
                static const AkUniqueID HIGH = 3550808449U;
                static const AkUniqueID LOW = 545371365U;
                static const AkUniqueID NONE = 748895195U;
            } // namespace STATE
        } // namespace COMBATTENSION

        namespace GAMESTATE
        {
            static const AkUniqueID GROUP = 4091656514U;

            namespace STATE
            {
                static const AkUniqueID BEACH = 4075332698U;
                static const AkUniqueID COMBAT = 2764240573U;
                static const AkUniqueID EXPLORATION = 2582085496U;
                static const AkUniqueID NONE = 748895195U;
                static const AkUniqueID TOWN = 3091570009U;
            } // namespace STATE
        } // namespace GAMESTATE

        namespace INSIDE
        {
            static const AkUniqueID GROUP = 3553349781U;

            namespace STATE
            {
                static const AkUniqueID FALSE = 2452206122U;
                static const AkUniqueID NONE = 748895195U;
                static const AkUniqueID TRUE = 3053630529U;
            } // namespace STATE
        } // namespace INSIDE

        namespace TIMEOFDAY
        {
            static const AkUniqueID GROUP = 3729505769U;

            namespace STATE
            {
                static const AkUniqueID DAY = 311764537U;
                static const AkUniqueID NIGHT = 1011622525U;
                static const AkUniqueID NONE = 748895195U;
            } // namespace STATE
        } // namespace TIMEOFDAY

        namespace UNDERWATER
        {
            static const AkUniqueID GROUP = 2213237662U;

            namespace STATE
            {
                static const AkUniqueID FALSE = 2452206122U;
                static const AkUniqueID NONE = 748895195U;
                static const AkUniqueID TRUE = 3053630529U;
            } // namespace STATE
        } // namespace UNDERWATER

    } // namespace STATES

    namespace GAME_PARAMETERS
    {
        static const AkUniqueID ISRAINING = 844393037U;
        static const AkUniqueID SIDECHAINING = 4120525729U;
        static const AkUniqueID SS_AIR_FEAR = 1351367891U;
        static const AkUniqueID SS_AIR_FREEFALL = 3002758120U;
        static const AkUniqueID SS_AIR_FURY = 1029930033U;
        static const AkUniqueID SS_AIR_MONTH = 2648548617U;
        static const AkUniqueID SS_AIR_PRESENCE = 3847924954U;
        static const AkUniqueID SS_AIR_RPM = 822163944U;
        static const AkUniqueID SS_AIR_SIZE = 3074696722U;
        static const AkUniqueID SS_AIR_STORM = 3715662592U;
        static const AkUniqueID SS_AIR_TIMEOFDAY = 3203397129U;
        static const AkUniqueID SS_AIR_TURBULENCE = 4160247818U;
    } // namespace GAME_PARAMETERS

    namespace TRIGGERS
    {
        static const AkUniqueID COLLECT_ITEM = 3868165313U;
        static const AkUniqueID ENTERCOMBAT = 2334212825U;
        static const AkUniqueID EXITCOMBAT = 755913789U;
        static const AkUniqueID PLAYER_GOTOBED = 1659302645U;
    } // namespace TRIGGERS

    namespace BANKS
    {
        static const AkUniqueID INIT = 1355168291U;
        static const AkUniqueID MASTER = 4056684167U;
    } // namespace BANKS

    namespace BUSSES
    {
        static const AkUniqueID AMB = 1117531639U;
        static const AkUniqueID MASTER_AUDIO_BUS = 3803692087U;
        static const AkUniqueID MUSIC = 3991942870U;
        static const AkUniqueID REVERB = 348963605U;
        static const AkUniqueID SFX = 393239870U;
        static const AkUniqueID STINGERS = 2940432316U;
        static const AkUniqueID VO = 1534528548U;
    } // namespace BUSSES

    namespace AUX_BUSSES
    {
        static const AkUniqueID REVERB_INDOOR = 603224157U;
        static const AkUniqueID REVERB_OUTDOOR = 1578973140U;
    } // namespace AUX_BUSSES

    namespace AUDIO_DEVICES
    {
        static const AkUniqueID NO_OUTPUT = 2317455096U;
        static const AkUniqueID SYSTEM = 3859886410U;
    } // namespace AUDIO_DEVICES

}// namespace AK

#endif // __WWISE_IDS_H__
