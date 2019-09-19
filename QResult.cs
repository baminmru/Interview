using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

  
        public class Header
        {
            public string id { get; set; }
            public string status { get; set; }
        }

        public class Language
        {
            public string language { get; set; }
            public double probability { get; set; }
            public double fr { get; set; }
            public double fa { get; set; }
        }

        public class VadSegmentation
        {
            public string bpa { get; set; }
            public double snr { get; set; }
            public string path { get; set; }
            public string audio { get; set; }
            public List<double> ranges { get; set; }
            public double ranges_duration { get; set; }
            public double rt_rms { get; set; }
            public double quality { get; set; }
            public double rt_aver { get; set; }
            public int rt_count { get; set; }
            public string algorithm { get; set; }
            public List<Language> languages { get; set; }
            public string audio_hash { get; set; }
            public string bio_version { get; set; }
            public double time_speech { get; set; }
            public string channel_type { get; set; }
            public double time_overload { get; set; }
            public string channel_number { get; set; }
            public double time_tonal_noise { get; set; }
            public double processed_duration { get; set; }
            public string state { get; set; }
            public bool processed_partially { get; set; }
            public double lowest_speech_freq_hz { get; set; }
            public double highest_speech_freq_hz { get; set; }
            public double max_unclipped_interval { get; set; }
            public double speech_amplitude_threshold_db { get; set; }
        }

        public class Result
        {
            public List<VadSegmentation> vad_segmentations { get; set; }
        }

        public class RootObject
        {
            public bool success { get; set; }
            public Result body { get; set; }
        }
    

}
