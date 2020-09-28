﻿using System.Diagnostics;

// ReSharper disable once CheckNamespace
namespace SenseNet.Packaging
{
    public enum PatchExecutionEventType
    {
        DuplicatedInstaller, CannotExecute, CannotExecuteMissingVersion, PackageNotSaved,
        OnBeforeActionStarts, OnBeforeActionFinished, OnAfterActionStarts, OnAfterActionFinished, 
        ExecutionError
    }
    [DebuggerDisplay("{ToString()}")]
    public struct PatchExecutionLogRecord
    {
        public PatchExecutionEventType EventType { get; }
        public ISnPatch Patch { get; }
        public string Message { get; }

        public PatchExecutionLogRecord(PatchExecutionEventType eventType, ISnPatch patch, string message = null)
        {
            EventType = eventType;
            Patch = patch;
            Message = message;
        }

        public override string ToString()
        {
            return Message == null
                ? $"[{Patch}] {EventType}."
                : $"[{Patch}] {EventType}. {Message}";
        }
    }
}
