class SecurePerson
{
    private string socialId;

    public void SetSocialId(string id)
    {
        socialId = id;   // basic, no validation
    }

    public string GetSocialId()
    {
        return socialId;
    }
}
