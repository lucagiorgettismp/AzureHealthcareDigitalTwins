using System;
using Microsoft.MixedReality.Toolkit;

public interface IQRCodeTrackingService : IMixedRealityExtensionService
{
    event EventHandler Initialized;
    event EventHandler<QRInfo> QRCodeFound;

    bool InitializationFailed { get; }
    string ErrorMessage { get; }
    string ProgressMessages { get; }
    bool IsSupported { get; }
    bool IsTracking { get; }
    bool IsInitialized { get; }
}
