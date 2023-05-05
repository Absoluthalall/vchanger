from django.urls import path
from . import views
from .views import RegisterUser, LoginUser
from django.contrib.auth import views as auth_views

urlpatterns = [
    path('', views.index, name="home"),
    path('FaQ/', views.faq, name="FaQ"),
    # path('Catalog/', views.catalog, name="Catalog"),
    path('About/', views.aboutUs, name="About"),
    path('RegisterForm/', RegisterUser.as_view(), name="RegisterForm"),
    path('Login/', LoginUser.as_view(), name="Login"),
    path('Logout/', views.user_logout, name="Logout"),
    path('Profile/', views.profile, name="Profile"),
    path('password_reset/',auth_views.PasswordResetView.as_view(),name='password_reset'),
    path('password_reset/done/',auth_views.PasswordResetDoneView.as_view(),name='password_reset_done'),
    path('reset/<uidb64>/<token>/',auth_views.PasswordResetConfirmView.as_view(),name='password_reset_confirm'),
    path('reset/done/',auth_views.PasswordResetCompleteView.as_view(),name='password_reset_complete'),
    path('profile_update/', views.profile_update, name="profile_update"),
    # path('ProInfo/', views.pro, name="ProInfo"),
    # path('PremiumInfo/', views.premium, name="PremiumInfo"),
    # path('GodInfo/', views.god, name="GodInfo"),
]