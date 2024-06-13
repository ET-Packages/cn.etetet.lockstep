namespace ET.Client
{
    public struct Wait_Room2C_Start: IWaitType
    {
        public int Error { get; set; }

        public Room2C_Start Message;
    }
    
    public struct Wait_SceneChangeFinish: IWaitType
    {
        public int Error
        {
            get;
            set;
        }
    }
}