using System;
using System.IO;

namespace Sdcb.SimdPaddleOCR.Models.DocumentOrientation;

/// <summary>
/// Embedded PP-LCNet_x1_0_doc_ori (ONNX): four-way whole-page orientation, 0 / 90 / 180 / 270
/// degrees clockwise. Pass <see cref="OpenRead"/> to
/// <c>new Sdcb.SimdPaddleOCR.PaddleOcrDocumentOrientationClassifier(Stream)</c>.
/// </summary>
public static class DocumentOrientationModel
{
    /// <summary>Official PaddleOCR model name.</summary>
    public const string Name = "PP-LCNet_x1_0_doc_ori";

    /// <summary>Hugging Face revision of PaddlePaddle/PP-LCNet_x1_0_doc_ori the ONNX was converted from.</summary>
    public const string SourceRevision = "d3b95a6dff5fe8a94f2748e12b61cb26818a0df8";

    /// <summary>
    /// Opens a new read-only stream over the embedded ONNX model, positioned at the start; reading it
    /// forward once is enough. The caller disposes it.
    /// </summary>
    public static Stream OpenRead() => typeof(DocumentOrientationModel).Assembly.GetManifestResourceStream(
        "Sdcb.SimdPaddleOCR.Models.DocumentOrientation." + Name + ".onnx")
        ?? throw new InvalidOperationException("Embedded model resource was not found.");
}