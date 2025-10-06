namespace DPM225461_NguyenThiBichQuan_Pattern04_Prototype
{
    class ConcretePrototype2 : Prototype
    {
        public ConcretePrototype2(string id) : base(id) { }
        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }
}
