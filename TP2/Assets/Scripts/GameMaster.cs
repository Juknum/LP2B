using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour {
  public GameObject BrickPrefab;
  public GameObject BrickGreyScalePrefab;

  public float xOffset = 0;
  public float yOffset = 0;

  private string shape1 = "xx..xxxxx.." + "x.xx.x.xx.x" + "..xxxxx..xx";
  private string shape2 = "  ..xxxxx  " + "x.  .x.  .x" + "  xxxxx..  ";
  private string shape3 = "xx    xxx.." + "x.xxxxxxx.x" + "..xxx    xx";
  private string shape4 = "xx..  x  .." + "x.  .x.  .x" + "..  x  ..xx";
  private string shape5 = "..xx.x.xx.." + "xx..x.x..xx" + "..xx.x.xx..";

  private int bricksLeft;

  void Start() {
    GenerateShape(Random.Range(0, 4));
  }

  void Update() {}

  public int ReportBrickDeath() {
    return bricksLeft;
  }

  public void setReportBrickDeath(int bricks) {
    bricksLeft = bricks;
  }

  public void GenerateShape(int shapeInt) {
    string shape = "";

    switch(shapeInt) {
      case 0:
        shape = shape1;
        break;
      case 1:
        shape = shape2;
        break;
      case 2:
        shape = shape3;
        break;
      case 3:
        shape = shape4;
        break;
      case 4:
        shape = shape5;
        break;
      default:
        shape = shape1;
        break;
    }

    int charNum = 0;

    for (int y = 0; y < 3; y++) {
      for (int x = 0; x < shape.Length / 3; x++) {
        char c = shape[charNum];
        charNum++;

        if (c == 'x') {
          GameObject newBrick = Instantiate(BrickPrefab);
          newBrick.transform.position = new Vector2(x * .9f + xOffset, y * .5f + yOffset);

          bricksLeft++;
        }
        else if (c == '.') {
          GameObject newBrick = Instantiate(BrickGreyScalePrefab);
          newBrick.transform.position = new Vector2(x * .9f + xOffset, y * .5f + yOffset);

          bricksLeft++;
        }
      }
    }

  }
}