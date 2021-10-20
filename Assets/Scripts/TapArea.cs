using UnityEngine;

using UnityEngine.EventSystems;



public class TapArea : MonoBehaviour, IPointerDownHandler

{
    public int tapCounter = 0;
    public void OnPointerDown(PointerEventData eventData)

    {
        GameManager.Instance.CollectByTap(eventData.position, transform);
        tapCounter++;
        AchievementController.Instance.UnlockAchievement(AchievementType.ClickedReached, tapCounter.ToString());
    }

}