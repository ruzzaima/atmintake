<Query Kind="Program">
  <Connection>
    <ID>ea97f3e2-8c92-422f-8e79-39b1d2801c10</ID>
    <Persist>true</Persist>
    <Server>(localdb)\Projects</Server>
    <Database>DB_996412_intake2</Database>
    <DisplayName>atm.intake</DisplayName>
  </Connection>
  <Reference Relative="..\domain\atm.domain\bin\Debug\atm.domain.dll">D:\project\work\atmintake\domain\atm.domain\bin\Debug\atm.domain.dll</Reference>
  <Reference Relative="..\library\domain.sph.dll">D:\project\work\atmintake\library\domain.sph.dll</Reference>
  <Reference Relative="..\library\Newtonsoft.Json.dll">D:\project\work\atmintake\library\Newtonsoft.Json.dll</Reference>
</Query>

void Main()
{
	var users = new List<SevenH.MMCSB.Atm.Domain.LoginUser>();
	using (var conn = new SqlConnection(@"Data Source=(localdb)\Projects;Initial Catalog=DB_996412_intake2;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False"))
	using (var cmd = new SqlCommand("SELECT * FROM tblUser", conn))
	{
		conn.Open();
		using (var reader = cmd.ExecuteReader())
		{
			while (reader.Read())
			{
				var us = new SevenH.MMCSB.Atm.Domain.LoginUser()
				{
					Id = reader.GetInt32(0).ToString(),
					ApplicantId = reader.GetNullableInt32(1),
					LoginId = reader.GetString(2),
					FullName = reader.GetString(3),
					UserName = reader.GetString(4),
					Email = reader.GetString(5),
					AlternativeEmail = reader.GetString(6),
					ServiceCd = reader.ToString(7),
					Salt = reader.GetString(8),
					WebId = reader.GetString(9), // PAssword
					IsLockedOut = reader.GetBoolean(10),
					FirstTime = reader.GetBoolean(11),
					LastLoginDt = reader.GetNullableDateTime(12),
					CreatedDate = reader.GetDateTime(13),
					CreatedBy = reader.ToString(14),
					ChangedDate = reader.GetNullableDateTime(15) ?? DateTime.Now,
					ChangedBy = reader.ToString(16),
					LastLoginDt2 = reader.GetNullableDateTime(17),
					Designation = "Public",
					HasChangedDefaultPassword = true,
					Bil = reader.GetInt32(0),
					Department = null,
					Dirty = false,
					IsLocked = reader.GetBoolean(10),
					Telephone = "",
					Status = ""
					
					
				};
				users.Add(us);
			}

		}

	}

	var usp = from u in users
			  select new UserProfile
			  {
				  ChangedBy = u.ChangedBy ?? "LINQPAD",
				  ChangedDate = u.ChangedDate,
				  CreatedBy = u.CreatedBy,
				  CreatedDate = u.CreatedDate,
				  Department = "",
				  Designation = u.Designation,
				  Email = u.Email,
				  FullName = u.FullName,
				  Id = u.Id,
				  Json = Bespoke.Sph.Domain.JsonSerializerService.ToJsonString(u,true),
				  UserName = u.UserName
			  };
	UserProfiles.InsertAllOnSubmit(usp);
	SubmitChanges();
}

// Define other methods and classes here
static class Helper
{
	public static DateTime? GetNullableDateTime(this IDataReader reader, int ordinal)
	{
		var val = reader[ordinal];
		if (val == DBNull.Value) return null;
		return (DateTime)val;
	}
	public static int? GetNullableInt32(this IDataReader reader, int ordinal)
	{
		var val = reader[ordinal];
		if (val == DBNull.Value) return null;
		return (int)val;
	}
	public static string ToString(this IDataReader reader, int ordinal)
	{
		var val = reader[ordinal];
		if (val == DBNull.Value) return null;
		return (string)val;
	}
}