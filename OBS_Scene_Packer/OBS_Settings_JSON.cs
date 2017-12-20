// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using QuickType;
//
//    var data = ObsJson.FromJson(jsonString);
//
namespace QuickType
{
    using System;
    using System.Net;
    using System.Collections.Generic;

    using Newtonsoft.Json;

    public partial class ObsJson
    {
        [JsonProperty("AuxAudioDevice1")]
        public AuxAudioDevice1 AuxAudioDevice1 { get; set; }

        [JsonProperty("DesktopAudioDevice1")]
        public DesktopAudioDevice1 DesktopAudioDevice1 { get; set; }

        [JsonProperty("current_program_scene")]
        public string CurrentProgramScene { get; set; }

        [JsonProperty("current_scene")]
        public string CurrentScene { get; set; }

        [JsonProperty("current_transition")]
        public string CurrentTransition { get; set; }

        [JsonProperty("modules")]
        public Modules Modules { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("preview_locked")]
        public bool PreviewLocked { get; set; }

        [JsonProperty("quick_transitions")]
        public List<QuickTransition> QuickTransitions { get; set; }

        [JsonProperty("saved_preview_projectors")]
        public List<SavedPreviewProjector> SavedPreviewProjectors { get; set; }

        [JsonProperty("saved_projectors")]
        public List<SavedProjector> SavedProjectors { get; set; }

        [JsonProperty("scaling_enabled")]
        public bool ScalingEnabled { get; set; }

        [JsonProperty("scaling_level")]
        public long ScalingLevel { get; set; }

        [JsonProperty("scaling_off_x")]
        public long ScalingOffX { get; set; }

        [JsonProperty("scaling_off_y")]
        public long ScalingOffY { get; set; }

        [JsonProperty("scene_order")]
        public List<SceneOrder> SceneOrder { get; set; }

        [JsonProperty("sources")]
        public List<Source> Sources { get; set; }

        [JsonProperty("transition_duration")]
        public long TransitionDuration { get; set; }

        [JsonProperty("transitions")]
        public List<object> Transitions { get; set; }
    }

    public partial class Source
    {
        [JsonProperty("deinterlace_field_order")]
        public long DeinterlaceFieldOrder { get; set; }

        [JsonProperty("deinterlace_mode")]
        public long DeinterlaceMode { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("flags")]
        public long Flags { get; set; }

        [JsonProperty("hotkeys")]
        public Dictionary<string, List<object>> Hotkeys { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("mixers")]
        public long Mixers { get; set; }

        [JsonProperty("monitoring_type")]
        public long MonitoringType { get; set; }

        [JsonProperty("muted")]
        public bool Muted { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("private_settings")]
        public FilterHotkeys PrivateSettings { get; set; }

        [JsonProperty("push-to-mute")]
        public bool PushToMute { get; set; }

        [JsonProperty("push-to-mute-delay")]
        public long PushToMuteDelay { get; set; }

        [JsonProperty("push-to-talk")]
        public bool PushToTalk { get; set; }

        [JsonProperty("push-to-talk-delay")]
        public long PushToTalkDelay { get; set; }

        [JsonProperty("settings")]
        public SourceSettings Settings { get; set; }

        [JsonProperty("sync")]
        public long Sync { get; set; }

        [JsonProperty("volume")]
        public double Volume { get; set; }
    }

    public partial class SourceSettings
    {
        [JsonProperty("file")]
        public string File { get; set; }

        [JsonProperty("chatlog")]
        public bool? Chatlog { get; set; }

        [JsonProperty("font")]
        public Font Font { get; set; }

        [JsonProperty("read_from_file")]
        public bool? ReadFromFile { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("id_counter")]
        public long? IdCounter { get; set; }

        [JsonProperty("items")]
        public List<Item> Items { get; set; }

        [JsonProperty("height")]
        public long? Height { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("width")]
        public long? Width { get; set; }

        [JsonProperty("last_video_device_id")]
        public string LastVideoDeviceId { get; set; }

        [JsonProperty("video_device_id")]
        public string VideoDeviceId { get; set; }

        [JsonProperty("align")]
        public string Align { get; set; }
    }

    public partial class Item
    {
        [JsonProperty("align")]
        public long Align { get; set; }

        [JsonProperty("bounds")]
        public Bounds Bounds { get; set; }

        [JsonProperty("bounds_align")]
        public long BoundsAlign { get; set; }

        [JsonProperty("bounds_type")]
        public long BoundsType { get; set; }

        [JsonProperty("crop_bottom")]
        public long CropBottom { get; set; }

        [JsonProperty("crop_left")]
        public long CropLeft { get; set; }

        [JsonProperty("crop_right")]
        public long CropRight { get; set; }

        [JsonProperty("crop_top")]
        public long CropTop { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("locked")]
        public bool Locked { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pos")]
        public Pos Pos { get; set; }

        [JsonProperty("private_settings")]
        public FilterHotkeys PrivateSettings { get; set; }

        [JsonProperty("rot")]
        public long Rot { get; set; }

        [JsonProperty("scale")]
        public Scale Scale { get; set; }

        [JsonProperty("scale_filter")]
        public string ScaleFilter { get; set; }

        [JsonProperty("visible")]
        public bool Visible { get; set; }
    }

    public partial class Scale
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }
    }

    public partial class Pos
    {
        [JsonProperty("x")]
        public long X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }
    }

    public partial class Bounds
    {
        [JsonProperty("x")]
        public long X { get; set; }

        [JsonProperty("y")]
        public long Y { get; set; }
    }

    public partial class Font
    {
        [JsonProperty("face")]
        public string Face { get; set; }

        [JsonProperty("flags")]
        public long Flags { get; set; }

        [JsonProperty("size")]
        public long Size { get; set; }

        [JsonProperty("style")]
        public string Style { get; set; }
    }

    public partial class SceneOrder
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public partial class SavedProjector
    {
        [JsonProperty("saved_projectors")]
        public string SavedProjectors { get; set; }
    }

    public partial class SavedPreviewProjector
    {
        [JsonProperty("saved_preview_projectors")]
        public long SavedPreviewProjectors { get; set; }
    }

    public partial class QuickTransition
    {
        [JsonProperty("duration")]
        public long Duration { get; set; }

        [JsonProperty("hotkeys")]
        public List<object> Hotkeys { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public partial class Modules
    {
        [JsonProperty("auto-scene-switcher")]
        public AutoSceneSwitcher AutoSceneSwitcher { get; set; }

        [JsonProperty("captions")]
        public Captions Captions { get; set; }

        [JsonProperty("output-timer")]
        public OutputTimer OutputTimer { get; set; }
    }

    public partial class OutputTimer
    {
        [JsonProperty("autoStartRecordTimer")]
        public bool AutoStartRecordTimer { get; set; }

        [JsonProperty("autoStartStreamTimer")]
        public bool AutoStartStreamTimer { get; set; }

        [JsonProperty("recordTimerHours")]
        public long RecordTimerHours { get; set; }

        [JsonProperty("recordTimerMinutes")]
        public long RecordTimerMinutes { get; set; }

        [JsonProperty("recordTimerSeconds")]
        public long RecordTimerSeconds { get; set; }

        [JsonProperty("streamTimerHours")]
        public long StreamTimerHours { get; set; }

        [JsonProperty("streamTimerMinutes")]
        public long StreamTimerMinutes { get; set; }

        [JsonProperty("streamTimerSeconds")]
        public long StreamTimerSeconds { get; set; }
    }

    public partial class Captions
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("lang_id")]
        public long LangId { get; set; }

        [JsonProperty("provider")]
        public string Provider { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }
    }

    public partial class AutoSceneSwitcher
    {
        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("interval")]
        public long Interval { get; set; }

        [JsonProperty("non_matching_scene")]
        public string NonMatchingScene { get; set; }

        [JsonProperty("switch_if_not_matching")]
        public bool SwitchIfNotMatching { get; set; }

        [JsonProperty("switches")]
        public List<object> Switches { get; set; }
    }

    public partial class DesktopAudioDevice1
    {
        [JsonProperty("deinterlace_field_order")]
        public long DeinterlaceFieldOrder { get; set; }

        [JsonProperty("deinterlace_mode")]
        public long DeinterlaceMode { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("flags")]
        public long Flags { get; set; }

        [JsonProperty("hotkeys")]
        public AuxAudioDevice1Hotkeys Hotkeys { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("mixers")]
        public long Mixers { get; set; }

        [JsonProperty("monitoring_type")]
        public long MonitoringType { get; set; }

        [JsonProperty("muted")]
        public bool Muted { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("private_settings")]
        public FilterHotkeys PrivateSettings { get; set; }

        [JsonProperty("push-to-mute")]
        public bool PushToMute { get; set; }

        [JsonProperty("push-to-mute-delay")]
        public long PushToMuteDelay { get; set; }

        [JsonProperty("push-to-talk")]
        public bool PushToTalk { get; set; }

        [JsonProperty("push-to-talk-delay")]
        public long PushToTalkDelay { get; set; }

        [JsonProperty("settings")]
        public AuxAudioDevice1Settings Settings { get; set; }

        [JsonProperty("sync")]
        public long Sync { get; set; }

        [JsonProperty("volume")]
        public double Volume { get; set; }
    }

    public partial class AuxAudioDevice1
    {
        [JsonProperty("deinterlace_field_order")]
        public long DeinterlaceFieldOrder { get; set; }

        [JsonProperty("deinterlace_mode")]
        public long DeinterlaceMode { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("filters")]
        public List<Filter> Filters { get; set; }

        [JsonProperty("flags")]
        public long Flags { get; set; }

        [JsonProperty("hotkeys")]
        public AuxAudioDevice1Hotkeys Hotkeys { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("mixers")]
        public long Mixers { get; set; }

        [JsonProperty("monitoring_type")]
        public long MonitoringType { get; set; }

        [JsonProperty("muted")]
        public bool Muted { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("private_settings")]
        public FilterHotkeys PrivateSettings { get; set; }

        [JsonProperty("push-to-mute")]
        public bool PushToMute { get; set; }

        [JsonProperty("push-to-mute-delay")]
        public long PushToMuteDelay { get; set; }

        [JsonProperty("push-to-talk")]
        public bool PushToTalk { get; set; }

        [JsonProperty("push-to-talk-delay")]
        public long PushToTalkDelay { get; set; }

        [JsonProperty("settings")]
        public AuxAudioDevice1Settings Settings { get; set; }

        [JsonProperty("sync")]
        public long Sync { get; set; }

        [JsonProperty("volume")]
        public long Volume { get; set; }
    }

    public partial class AuxAudioDevice1Settings
    {
        [JsonProperty("device_id")]
        public string DeviceId { get; set; }
    }

    public partial class AuxAudioDevice1Hotkeys
    {
        [JsonProperty("libobs.mute")]
        public List<object> LibobsMute { get; set; }

        [JsonProperty("libobs.push-to-mute")]
        public List<object> LibobsPushToMute { get; set; }

        [JsonProperty("libobs.push-to-talk")]
        public List<object> LibobsPushToTalk { get; set; }

        [JsonProperty("libobs.unmute")]
        public List<object> LibobsUnmute { get; set; }
    }

    public partial class Filter
    {
        [JsonProperty("deinterlace_field_order")]
        public long DeinterlaceFieldOrder { get; set; }

        [JsonProperty("deinterlace_mode")]
        public long DeinterlaceMode { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("flags")]
        public long Flags { get; set; }

        [JsonProperty("hotkeys")]
        public FilterHotkeys Hotkeys { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("mixers")]
        public long Mixers { get; set; }

        [JsonProperty("monitoring_type")]
        public long MonitoringType { get; set; }

        [JsonProperty("muted")]
        public bool Muted { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("private_settings")]
        public FilterHotkeys PrivateSettings { get; set; }

        [JsonProperty("push-to-mute")]
        public bool PushToMute { get; set; }

        [JsonProperty("push-to-mute-delay")]
        public long PushToMuteDelay { get; set; }

        [JsonProperty("push-to-talk")]
        public bool PushToTalk { get; set; }

        [JsonProperty("push-to-talk-delay")]
        public long PushToTalkDelay { get; set; }

        [JsonProperty("settings")]
        public FilterHotkeys Settings { get; set; }

        [JsonProperty("sync")]
        public long Sync { get; set; }

        [JsonProperty("volume")]
        public long Volume { get; set; }
    }

    public partial class FilterHotkeys
    {
    }

    public partial class ObsJson
    {
        public static ObsJson FromJson(string json) => JsonConvert.DeserializeObject<ObsJson>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this ObsJson self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    public class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
        };
    }
}
