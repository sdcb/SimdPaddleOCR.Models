# Sdcb.SimdPaddleOCR.Models.DocumentOrientation

Embedded **PP-LCNet_x1_0_doc_ori** (ONNX, 6.7 MB): four-way whole-page orientation
(0° / 90° / 180° / 270° clockwise) for [Sdcb.SimdPaddleOCR](https://github.com/sdcb/SimdPaddleOCR).
netstandard2.0, no dependencies; the package only exposes the model as a `Stream`.

```csharp
using Sdcb.SimdPaddleOCR;
using Sdcb.SimdPaddleOCR.Models.DocumentOrientation;

using var orientation = new PaddleOcrDocumentOrientationClassifier(DocumentOrientationModel.OpenRead());
PaddleOcrDocumentOrientationResult o = orientation.Classify(bgr, width, height);
// o.OrientationDegrees: rotate counterclockwise by this much (PaddleOcrDocumentRotation.Rotate) to make the page upright
```

Converted from <https://huggingface.co/PaddlePaddle/PP-LCNet_x1_0_doc_ori> at revision
`d3b95a6dff5fe8a94f2748e12b61cb26818a0df8` (Apache-2.0); see `manifest.json` in the package for the
source hashes, converter versions and the Paddle vs ONNX numerical comparison.