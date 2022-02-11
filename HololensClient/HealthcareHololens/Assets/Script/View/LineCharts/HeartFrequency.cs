using UnityEngine;

public class HeartFrequency
{
    DD_DataDiagram lineChart;
    readonly GameObject line;

    public HeartFrequency()
    {
        this.line = this.lineChart.AddLine("HeartFrequency", Color.green);
    }

    public void AddPoint(int value) {

        var point = new Vector2(1, value);
        this.lineChart.InputPoint(this.line, point);
    }
}
