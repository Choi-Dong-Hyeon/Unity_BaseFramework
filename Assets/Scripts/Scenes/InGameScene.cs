public class InGameScene : BaseScene
{
    void Start()
    {
        Init();
    }

    protected override void Init()
    {
        base.Init();
        _scene = Define.Scene.InGame;
    }

    public override void Clear()
    {

    }

}
