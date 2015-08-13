namespace SevenH.MMCSB.Atm.Domain
{
    public partial class LoginRole : DomainObject
    {
        public virtual LoginUser LoginUser { get; set; }

        public virtual void Save()
        {
            ObjectBuilder.GetObject<IRoleProvider>("RoleProvider").AddRoles(UserId, Roles);
        }
    }
}
