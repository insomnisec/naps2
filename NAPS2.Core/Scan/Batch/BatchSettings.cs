﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NAPS2.Scan.Batch
{
    public class BatchSettings
    {
        public string ProfileDisplayName { get; set; }

        public BatchScanType ScanType { get; set; }

        public int ScanCount { get; set; }

        public double ScanIntervalSeconds { get; set; }

        public BatchSaveType SaveType { get; set;  }

        public BatchSaveSeparator SaveSeparator { get; set; }

        public string SaveFolder { get; set; }

        public string SaveFileName { get; set; }
    }

    public enum BatchSaveSeparator
    {
        FilePerScan,
        FilePerImage,
        PatchT
    }

    public enum BatchSaveType
    {
        Load,
        SingleFile,
        MultipleFiles
    }

    public enum BatchScanType
    {
        Single,
        MultipleWithPrompt,
        MultipleWithDelay
    }
}
