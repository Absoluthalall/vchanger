from django import forms
from django.contrib.auth.forms import ReadOnlyPasswordHashField
from .models import MyUser
from .models import Profile
from django.core.exceptions import ValidationError

class UserCreationForm(forms.ModelForm):
    """A form for creating new users. Includes all the required
    fields, plus a repeated password."""
    password1 = forms.CharField(label='Password', widget=forms.PasswordInput)
    password2 = forms.CharField(label='Password confirmation', widget=forms.PasswordInput)

    class Meta:
        model = MyUser
        fields = ('email',)

    def clean_password2(self):
        # Check that the two password entries match
        password1 = self.cleaned_data.get("password1")
        password2 = self.cleaned_data.get("password2")
        if password1 and password2 and password1 != password2:
            raise ValidationError("Passwords don't match")
        return password2

    def save(self, commit=True):
        # Save the provided password in hashed format
        user = super().save(commit=False)
        user.set_password(self.cleaned_data["password1"])
        if commit:
            user.save()
        return user


class UserChangeForm(forms.ModelForm):
    """A form for updating users. Includes all the fields on
    the user, but replaces the password field with admin's
    disabled password hash display field.
    """
    password = ReadOnlyPasswordHashField()

    class Meta:
        model = MyUser
        fields = ('email',)
class RegisterUserForm(UserCreationForm):
    email = forms.CharField(label='Email', widget=forms.TextInput(attrs={'class': 'form-input'}))
    nickname = forms.CharField(label='Nickname', widget=forms.TextInput(attrs={'class': 'form-input'}))
    password1 = forms.CharField(label='Password', widget=forms.PasswordInput(attrs={'class': 'form-input'}))
    password2 = forms.CharField(label='Confirm Password', widget=forms.PasswordInput(attrs={'class': 'form-input'}))
    class Meta:
        model = MyUser
        fields = ('email', 'nickname', 'password1', 'password2')

class UserUpdateForm(forms.ModelForm):
    nickname = forms.CharField(label='Nickname', widget=forms.TextInput(attrs={'class': 'form-input'}))
    class Meta:
        model = MyUser
        fields = ('nickname',)
        
class ProfileUpdateForm(forms.ModelForm):
    class Meta:
        model = Profile
        fields = ('image',)