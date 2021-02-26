namespace OutAndRef
{
    public struct Person
    {
        public string Name { get; set; }
        public bool Licensed { get; set; }

        public override string ToString() => $"{Name} ({(Licensed ? "Licensed" : "Unlicensed")})";
    }
}
