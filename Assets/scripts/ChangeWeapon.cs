using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeWeapon : MonoBehaviour
{
  static public int bulletPower;
  static public int bulletSpeed;
  //private shooting shoot;

  /*
  public void Awake(){
    shoot = GameObject.FindObjectOfType<shooting>();
  }
  */
  // Start is called before the first frame update
  void Start()
  {

      //shoot = GameObject.FindObjectOfType<shooting>();
      bulletPower = 10;
      bulletSpeed = 1;

  }



  void Update(){
    if(Input.GetMouseButtonDown(0)){
      Change();
    }
    //int bs = bulletSpeed;
    //shoot.UpdateShoot(bulletSpeed);
    HUD.GetInstance().UpdateWeaponUI(bulletPower, bulletSpeed);
    //shoot.UpdateShoot(bs);
  }
  void Change(){
    bulletPower = bulletPower*2;
    bulletSpeed = bulletSpeed*2;
  }


  // Update is called once per frame
}
