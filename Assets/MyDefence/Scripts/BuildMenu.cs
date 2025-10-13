using UnityEngine;
namespace MyDefence
{
    /// <summary>
    /// 타워 선택 UI를 관리하는 클래스
    /// </summary>
    public class BuildMenu : MonoBehaviour
    {
        public void SelectMachineGun()
        {
            //Debug.Log("머신건 타워를 선택하였습니다");
            BuildManager.Instance.SetTurretToBuild(BuildManager.Instance.machineGunPrefab);
        }
    }
}