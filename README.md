# SimdPaddleOCR.Models

Extension models for [Sdcb.SimdPaddleOCR](https://github.com/sdcb/SimdPaddleOCR), kept out of the
main repository so its history stays small. Each package targets netstandard2.0, has no
dependencies, and only exposes its model as a forward-read `Stream`; the inference entry points
live in Sdcb.SimdPaddleOCR.

| Package | Model | Use with |
| --- | --- | --- |
| `Sdcb.SimdPaddleOCR.Models.DocumentOrientation` | PP-LCNet_x1_0_doc_ori, four-way page orientation (0/90/180/270) | `PaddleOcrDocumentOrientationClassifier` |

```csharp
using Sdcb.SimdPaddleOCR;
using Sdcb.SimdPaddleOCR.Models.DocumentOrientation;

using var orientation = new PaddleOcrDocumentOrientationClassifier(DocumentOrientationModel.OpenRead());
PaddleOcrDocumentOrientationResult o = orientation.Classify(bgr, width, height);
```

## Layout

- `models/<name>/`: the ONNX file and `manifest.json` (source revision, hashes, converter versions,
  numerical checks).
- `tools/`: conversion scripts that reproduce the ONNX files from the official Paddle models.
- `src/`: one packaging project per model; the ONNX is an embedded resource.
- `build/`: LINQPad scripts to pack (`01-build-packages.linq`) and publish
  (`02-publish-proget-nuget.linq`) the packages by hand. Versions live in `Directory.Build.props`
  and `build/00-common.linq`.

## Credits

The document orientation model conversion, preprocessing and validation come from
[sdcb/SimdPaddleOCR#32](https://github.com/sdcb/SimdPaddleOCR/pull/32) by
[@hnlyf168](https://github.com/hnlyf168).

## License

Code and documents: [Apache-2.0](LICENSE). Models keep their upstream licenses; see
[THIRD-PARTY-NOTICES.md](THIRD-PARTY-NOTICES.md).