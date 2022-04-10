using ZXing;
using GoogleARCore;
using UnityEngine;
using System;

public class ImageRecognition
{
    // is used at start of application to set initial position
    public bool StartPosition(WebCamTexture wt)
    {
        bool succeeded = false;
        try
        {
            IBarcodeReader barcodeReader = new BarcodeReader();
            // decode the current frame
            var result = barcodeReader.Decode(wt.GetPixels32(), wt.width, wt.height);
            if (result != null)
            {
                Relocate(result.Text);
                succeeded = true;
            }
        }
        catch (Exception ex) { Debug.LogWarning(ex.Message); }
        return succeeded;
    }

    // move to person indicator to the new spot
    private void Relocate(string text)
    {
        text = text.Trim(); //remove spaces
                            //find the correct location scanned and move the person to its position
        // TODO Krasi commented the below
        //foreach (Transform child in calibrationLocations.transform)
        //{
        //    if (child.name.Equals(text))
        //    {
        //        person.transform.position = child.position;
        //        break;
        //    }
        //}
        //searchingForMarker = false;
    }
}