from django.contrib.auth import logout, login
from django.contrib.auth.forms import AuthenticationForm
from django.contrib.auth.views import LoginView
from django.shortcuts import render, redirect
from django.contrib import messages
from django.http import HttpResponse
from django.urls import reverse_lazy
from django.views.generic import CreateView
from .forms import RegisterUserForm, ProfileUpdateForm, UserUpdateForm


def index(request):
    return render(request, 'main/index.html')

def faq(request):
    return render(request, 'main/faq.html')

def catalog(request):
    return render(request, 'main/catalog.html')

def aboutUs(request):
    return render(request, 'main/aboutUs.html')


class RegisterUser(CreateView):
    form_class = RegisterUserForm
    template_name = 'main/register.html'
    success_url = reverse_lazy('Login')


    def form_valid(self, form):
        user = form.save()
        login(self.request, user)
        return redirect('home')


class LoginUser(LoginView):
    form_class = AuthenticationForm
    template_name = 'main/login.html'

    def get_success_url(self):
        return reverse_lazy('home')


def user_logout(request):
    logout(request)
    return redirect('Login')


def profile(request):
    return render(request, 'main/profile.html')


def profile_update(request):
    if request.method == 'POST':
        u_form = UserUpdateForm(request.POST, instance=request.user)
        p_form = ProfileUpdateForm(request.POST, request.FILES, instance=request.user.profile)
        if u_form.is_valid() and p_form.is_valid():
            u_form.save()
            p_form.save()
            messages.success(request, f'Your account has been updated!')
            return redirect('Profile')
    else:
        u_form = UserUpdateForm(instance=request.user)
        p_form = ProfileUpdateForm(instance=request.user.profile)
    context = {
        'u_form': u_form,
        'p_form': p_form
    }
    
    return render(request, 'main/profile_update.html', context)

    
# def pro(request):
#     return render(request, 'main/proinfo.html')
    
    

# def premium(request):
#     return render(request, 'main/premiuminfo.html')
    
    
# def god(request):
#     return render(request, 'main/godinfo.html')



