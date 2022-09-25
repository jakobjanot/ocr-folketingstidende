// See https://aka.ms/new-console-template for more information
using IronOcr;
using System;
var Ocr = new IronTesseract();
//var ContentArea = new System.Drawing.Rectangle() { X = 215, Y = 1250, Height = 280, Width = 1335 };
// Dimensions are in in px


//using (var input = new OcrInput("files/example/0038.jpg", ContentArea))
using (var input = new OcrInput("files/example/0038.jpg"))
{
    input.DeNoise();
    input.Deskew();
    input.DeepCleanBackgroundNoise();
    input.EnhanceResolution();
    input.Contrast();
    input.ToGrayScale();
    var result = Ocr.Read(input);
    Console.WriteLine(result.Text);
    result.SaveAsHocrFile("results.html");
}
