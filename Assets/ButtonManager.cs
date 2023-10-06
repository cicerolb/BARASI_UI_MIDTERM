using DG.Tweening;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class ButtonManager : MonoBehaviour
{ 
    public Image imageToScale;
    private bool isZoomOut = false;
    private bool isFade = false;
    public Vector3 defaultPos;
    public Vector3 targetPos;
    public Vector3 leftTargetPos;
    public Vector3 upTargetPos;
    public Vector3 downTargetPos;
    public Vector3 swingTargetPos;
    private bool flyRight = false;
    private bool flyLeft = false;
    private bool flyUp = false;
    private bool flyDown = false;
    private bool swing = false;
   
    public void Zoom()
    {
        float zoomVal = 0;
        float targetScale = isZoomOut ? 1.0f : zoomVal;
        imageToScale.transform.DOScale(targetScale, 0.25f);
        isZoomOut = !isZoomOut;
    }

    public void FlyRight ()
    {
        Vector3 rightPos = flyRight ? defaultPos : targetPos;
        imageToScale.transform.DOLocalMove(rightPos, 0.25f);
        flyRight = !flyRight;
    }

    public void FlyLeft()
    {
        Vector3 leftPos = flyLeft ? defaultPos : leftTargetPos;
        imageToScale.transform.DOLocalMove(leftPos, 0.25f);
        flyLeft = !flyLeft;
    }

    public void FlyUp()
    {
        Vector3 upPos = flyUp ? defaultPos : upTargetPos;
        imageToScale.transform.DOLocalMove(upPos, 0.25f);
        flyUp = !flyUp;
    }
    
    public void FlyDown()
    {
        Vector3 downPos = flyDown ? defaultPos : downTargetPos;
        imageToScale.transform.DOLocalMove(downPos, 0.25f);
        flyDown = !flyDown;
    }

    public void SwingUp()
    {
        Vector3 swingPos = swing ? defaultPos : swingTargetPos;
        imageToScale.transform.DOLocalRotate(swingPos, 0.25f);
        swing = !swing;
    }
}

